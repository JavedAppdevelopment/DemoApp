using Microsoft.Practices.Unity;
using DemoApp.Common.DB;
using DemoApp.Common.Interfaces;
using DemoApp.Common.Logging;
using DemoApp.Common.Providers;
using DemoApp.Data.Database;
using DemoApp.Data.Interfaces;
using DemoApp.Data.Repositories;
using DemoApp.Data.Repositories.Interfaces;

namespace DemoApp.Data
{
	public class DataBootstrapper
	{		
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<ISqLiteConnectionFactory, SqLiteConnectionFactory>(new ContainerControlledLifetimeManager());
			container.RegisterType<ILogsInternalDatabase, LogsInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IAppInternalDatabase, ServiceClientInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IServiceClientInternalDatabase, ServiceClientInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IServiceClientDatabase, ServiceClientDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<ILoggingProvider, LogglyLocalDatabaseLoggingProvider>("LogglyLogger",new ContainerControlledLifetimeManager());
			container.RegisterType<ILogger, Logger>();
			container.RegisterType<IConnectivityHelper, ConnectivityHelper>(new ContainerControlledLifetimeManager());
			container.RegisterType<ILogsDatabase, LogsDatabase>(new HierarchicalLifetimeManager());

			// Repository Registration goes here.
			container.RegisterType<ITestRepository, TestRepository>(new TransientLifetimeManager());
		}
	}
}
