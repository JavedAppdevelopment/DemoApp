using DemoApp.Common.DB;
using DemoApp.Common.Interfaces;
using DemoApp.Data.Entities;
using DemoApp.Data.Interfaces;

namespace DemoApp.Data.Database
{
    public class ServiceClientInternalDatabase : AppInternalDatabase, IServiceClientInternalDatabase
	{
		public ServiceClientInternalDatabase(ISqLiteConnectionFactory connectionFactory) : base(connectionFactory.GetAppDBConnection())
		{
			// Create tables here, using following Way,
			Connection.CreateTable<TestEntity>();
		}
	}
}
