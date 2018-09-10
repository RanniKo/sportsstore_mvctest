using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel Kernel;

        public NinjectDependencyResolver(IKernel pKernel)
        {
            Kernel = pKernel;
            AddBindings();
        }

        private void AddBindings()
        {
            //binding
        }

        public object GetService(Type pServiceType)
        {
            return Kernel.TryGet(pServiceType);
        }

        public IEnumerable<object> GetServices(Type pServiceType)
        {
            return Kernel.GetAll(pServiceType);
        }
    }
}