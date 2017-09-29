using System;
using DemoApp.Common.DB;
using DemoApp.Common.Entities;
using DemoApp.Common.Interfaces;

namespace DemoApp.Common.Logging
{
	public class LogsInternalDatabase : AppInternalDatabase, ILogsInternalDatabase
	{
		public LogsInternalDatabase(ISqLiteConnectionFactory connectionFactory) : base(connectionFactory.GetLogsConnection())
		{
			// Create tables if they don't exist.
			Connection.CreateTable<LogEntry>();

			Connection.CreateIndex<LogEntry>(x => x.SentToServerAtUtc);
		}
	}
}
