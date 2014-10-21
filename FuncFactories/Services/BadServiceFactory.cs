using System;

namespace FuncFactories.Services
{
    public class BadServiceFactory : IServiceFactory
    {
        private readonly Func<SomeService> _serviceFactory;

        public BadServiceFactory(Func<SomeService> serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        public SomeService Create()
        {
            return _serviceFactory();
        }
    }
}