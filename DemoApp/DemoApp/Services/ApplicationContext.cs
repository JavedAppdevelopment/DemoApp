using DemoApp.Common.Interfaces;
using DemoApp.Common.Logging;

namespace DemoApp.Forms.Services
{
	public class ApplicationContext : IApplicationContext
	{		
		public string CurrentLoggedInUserName { get; set; }

		public LogLevel LogLevel { get; set; }
	}
}
