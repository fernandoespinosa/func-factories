using System;
using Autofac.Features.OwnedInstances;

namespace FuncFactories.Services
{
    public class GoodServiceFactory : IServiceFactory
    {
        private readonly Func<Owned<SomeService>> _serviceFactory;

        public GoodServiceFactory(Func<Owned<SomeService>> serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        public SomeService Create()
        {
            return _serviceFactory().Value;
        }
    }
}