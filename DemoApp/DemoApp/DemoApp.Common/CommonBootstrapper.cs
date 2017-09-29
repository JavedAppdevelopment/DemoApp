using Microsoft.Practices.Unity;
using DemoApp.Common.Logging;

namespace DemoApp.Common
{
	public class CommonBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<ILoggingProvider, ConsoleLoggingProvider>("ConsoleLogger", new ContainerControlledLifetimeManager());
		}
	}
}
