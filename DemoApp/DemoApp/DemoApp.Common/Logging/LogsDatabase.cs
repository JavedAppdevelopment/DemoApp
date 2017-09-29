using System;
using DemoApp.Common.Interfaces;
using DemoApp.Common.DB;

namespace DemoApp.Common.Logging
{
	public class LogsDatabase : AppDatabase, ILogsDatabase
	{
		public LogsDatabase(ILogsInternalDatabase database) : base(database)
		{
		}
	}
}
