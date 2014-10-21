using log4net;
using System;

namespace FuncFactories.Services
{
    public class SomeService : IDisposable
    {
        private static int instanceCounter;
        private readonly ILog _log;

        public SomeService(ILog log)
        {
            _log = log;
        }

        ~SomeService()
        {
            _log.DebugFormat("Service #{0} is being garbage collected!", ++instanceCounter);
        }

        public int ComputeSomething()
        {
            return new Random().Next();
        }

        public void Dispose()
        {
            _log.InfoFormat("Service #{0} is being disposed. WOW! big deal...", ++instanceCounter);
        }
    }
}