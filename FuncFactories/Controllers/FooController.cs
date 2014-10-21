using FuncFactories.Services;
using System.Web.Http;

namespace FuncFactories.Controllers
{
    [RoutePrefix("foo")]
    public class FooController : ApiController
    {
        private readonly BadServiceFactory _serviceFactory;

        public FooController(BadServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        [Route]
        public int GetSomething()
        {
            using (var service = _serviceFactory.Create())
            {
                return service.ComputeSomething();
            }
        }
    }
}
