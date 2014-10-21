using FuncFactories.Services;
using System.Web.Http;

namespace FuncFactories.Controllers
{
    [RoutePrefix("bar")]
    public class BarController : ApiController
    {
        private readonly GoodServiceFactory _serviceFactory;

        public BarController(GoodServiceFactory serviceFactory)
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