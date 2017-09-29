using System;
using DemoApp.Common.DB;
using DemoApp.Data.Interfaces;

namespace DemoApp.Data.Database
{
	public class ServiceClientDatabase : AppDatabase, IServiceClientDatabase
	{
		public ServiceClientDatabase(IServiceClientInternalDatabase database) : base(database)
		{
		}
	}
}
