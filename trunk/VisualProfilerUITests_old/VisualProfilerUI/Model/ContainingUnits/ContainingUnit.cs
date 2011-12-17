using System.Collections.Generic;
using System.Diagnostics.Contracts;
using VisualProfilerUI.Model.CriteriaContexts;

namespace VisualProfilerUI.Model.ContainingUnits
{
    public interface IContainingUnit
    {
        ICriteriaContext CriteriaContext { get; }
        IEnumerable<Method> ContainedMethods { get; }
        string DisplayName { get; }
        string FullName { get; }
    }

    public abstract class ContainingUnit : IContainingUnit
    {
        protected ContainingUnit(
            ICriteriaContext criteriaContext,
            IEnumerable<Method> containedMethods,
            string name,
            string displayName)
        {
            Contract.Requires(criteriaContext != null);
            Contract.Requires(containedMethods != null);
            CriteriaContext = criteriaContext;
            ContainedMethods = containedMethods;
            DisplayName = name;
            FullName = displayName;
        }

        public ICriteriaContext CriteriaContext { get; private set; }
        public IEnumerable<Method> ContainedMethods { get; private set; }
        public string DisplayName { get; private set; }
        public string FullName { get; private set; }
    }
}