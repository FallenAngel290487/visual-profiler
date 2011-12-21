using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;
using Ninject;
using VisualProfilerAccess.ProfilingData.CallTrees;

namespace VisualProfilerAccess.ProfilingData
{
    public class ProfilerAccess<TCallTree> where TCallTree : CallTree
    {
        private const string NamePipeName = "VisualProfilerAccessPipe";
        protected static StandardKernel Kernel = new StandardKernel(new VisualProfilerModule());
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly ProfilerCommunicator<TCallTree> _profilerCommunicator;
        private Task _actionReceiverTask;
        private Task _commandSenderTask;
        private NamedPipeServerStream _pipeServer;
        private readonly ManualResetEvent _stopProfilingEvent = new ManualResetEvent(true);

        public ProfilerAccess(
            ProcessStartInfo profileeProcessStartInfo,
            ProfilerTypes profilerType,
            TimeSpan profilingDataUpdatePeriod,
            ProfilerCommunicator<TCallTree> profilerCommunicator)
        {
            Contract.Requires(profileeProcessStartInfo != null);
            Contract.Requires(profilerCommunicator != null);

            _profilerCommunicator = profilerCommunicator;
            ProfilerType = profilerType;
            ProfileeProcessStartInfo = profileeProcessStartInfo;
            ProfilerDataUpdatePeriod = profilingDataUpdatePeriod;
            ProfilerStarted = false;
        }

        private Guid ProfilerCClassGuid
        {
            get
            {
                string profilerGuidString = string.Format("{{19840906-C001-0000-000C-00000000000{0}}}",
                                                          (int) ProfilerType);
                var profilerGuid = new Guid(profilerGuidString);
                return profilerGuid;
            }
        }

        public ProcessStartInfo ProfileeProcessStartInfo { get; private set; }
        public ProfilerTypes ProfilerType { get; private set; }
        public TimeSpan ProfilerDataUpdatePeriod { get; private set; }
        public Process ProfileeProcess { get; private set; }
        public bool ProfilerStarted { get; private set; }


        private void InitNamePipe()
        {
            _pipeServer = new NamedPipeServerStream("VisualProfilerAccessPipe", PipeDirection.InOut, 1,
                                                    PipeTransmissionMode.Byte, PipeOptions.Asynchronous);
        }

        private void StartReceiveActionsFromProfilee()
        {
            _actionReceiverTask = new Task(InboundMessageLoop, _cancellationTokenSource,
                                           TaskCreationOptions.LongRunning);
            _actionReceiverTask.Start();
        }

        private void StartSendingCommandsToProfilee()
        {
            _commandSenderTask = new Task(OutboundMessageLoop, _cancellationTokenSource.Token,
                                          TaskCreationOptions.LongRunning);
            _commandSenderTask.Start();
        }

        private void StartProfileeProcess()
        {
            ProfileeProcessStartInfo.EnvironmentVariables.Add("COR_ENABLE_PROFILING", "1");
            ProfileeProcessStartInfo.EnvironmentVariables.Add("COR_PROFILER", ProfilerCClassGuid.ToString("B"));
            //TODO Pozor pevna cesta!!!!!
            ProfileeProcessStartInfo.EnvironmentVariables.Add("COR_PROFILER_PATH",
                                                              @"D:\Honzik\Desktop\visual-profiler\Debug\VisualProfilerBackend.dll");
            ProfileeProcessStartInfo.EnvironmentVariables.Add("VisualProfiler.PipeName", NamePipeName);
            ProfileeProcessStartInfo.UseShellExecute = false;
            ProfileeProcess = Process.Start(ProfileeProcessStartInfo);
        }

        private void InboundMessageLoop(object state)
        {
            CancellationToken cancellationToken = _cancellationTokenSource.Token;
            while (!cancellationToken.IsCancellationRequested)
            {
                bool finishLoop;
                _profilerCommunicator.ReceiveActionFromProfilee(_pipeServer, out finishLoop);
                if (finishLoop)
                {
                    _cancellationTokenSource.Cancel();
                    _stopProfilingEvent.Set();
                }
            }
        }

        private void OutboundMessageLoop(object state)
        {
            CancellationToken cancellationToken = _cancellationTokenSource.Token;
            _pipeServer.WaitForConnection();
            StartReceiveActionsFromProfilee();
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    _profilerCommunicator.SendCommandToProfilee(_pipeServer, Commands.SendProfilingData);
                }
                catch (IOException)
                {
                    bool problemOccurredBeforeCancellation = !cancellationToken.IsCancellationRequested;
                    _profilerCommunicator.SendCommandToProfilee(_pipeServer, Commands.FinishProfiling);
                    if (problemOccurredBeforeCancellation) throw;
                }
                Thread.Sleep(ProfilerDataUpdatePeriod);
                _stopProfilingEvent.WaitOne();
            }
        }

        public void StartProfiler()
        {
            if (!ProfilerStarted)
            {
                InitNamePipe();
                StartSendingCommandsToProfilee();
                StartProfileeProcess();
                ProfilerStarted = true;
            }else
            {
                _stopProfilingEvent.Set();
            }
        
        }

        public void StopProfiler()
        {
            if(ProfilerStarted)
            {
                _stopProfilingEvent.Reset();
                
            }
        }

        public void Wait()
        {
            _commandSenderTask.Wait();
            _actionReceiverTask.Wait();
        }
    }
}