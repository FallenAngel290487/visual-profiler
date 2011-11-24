﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;

namespace VisualProfilerAccess.Metadata
{
    public class MethodMetadata : MetadataBase<MethodMetadata>
    {
        public string Name { get; set; }
        public string[] Parameters { get; set; }
        public ClassMetadata Class { get; set; }

        public override MetadataTypes MetadataType
        {
            get { return MetadataTypes.MethodMedatada; }
        }

        protected override void Deserialize(Stream byteStream)
        {
            Contract.Ensures(Class != null);

            Name = byteStream.DeserializeString();

            uint paramCount = byteStream.DeserializeUint32();
            Parameters = new string[paramCount];
            for (int i = 0; i < paramCount; i++)
            {
                string param = byteStream.DeserializeString();
                Parameters[i] = param;
            }

            uint classId = byteStream.DeserializeUint32();
            Class = ClassMetadata.Cache[classId];
        }

        public override string ToString()
        {
            string parameterString = string.Empty;
            foreach (var parameter in Parameters)
            {
                parameterString += parameter + ", ";
            }
            parameterString = parameterString.TrimEnd(", ".ToCharArray());

            string str = string.Format("[{0}]{1}.{2}({3})", Class.Module.Assembly.Name, Class.ToString() ,Name, parameterString);
            return str;
        }

        
    }
}