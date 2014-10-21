using Autofac;
using Autofac.Integration.WebApi;
using CP.KwikEMart.NUnit.Web.Http.SelfHost;
using FuncFactories.Services;
using log4net;
using log4net.Config;
using System;
using System.Reflection;
using System.Web.Http;
using System.Windows.Forms;

namespace FuncFactories.Host
{
    static class Program
    {
        private static ILog _log;

        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();
            _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            AppDomain.CurrentDomain.UnhandledException += AppDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            
            StartWebApplication();
            StartWindowsApplication();
        }

        private static void StartWebApplication()
        {
            var _webService = new HttpSelfHostService(8001);
            _webService.Configure(builder => {

                builder.RegisterApiControllers(typeof(SomeService).Assembly);
                builder.RegisterType<GoodServiceFactory>().SingleInstance();
                builder.RegisterType<BadServiceFactory>();
                builder.RegisterType<SomeService>();
                builder.RegisterInstance(_log).As<ILog>();

            }, (configuration, container) => {
                configuration.MapHttpAttributeRoutes();
                configuration.EnsureInitialized();
            });

            _webService.Open();
            _log.Info("Web Service Started!");
        }

        private static void StartWindowsApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Host());
        }

        private static void AppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            _log.Error("AppDomain.UnhandledException", (Exception) args.ExceptionObject);
            Environment.Exit(1);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs args)
        {
            _log.Error("Application.ThreadException", args.Exception);
        }
    }
}
