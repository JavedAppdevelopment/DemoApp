using DemoApp.Common.Logging;

namespace DemoApp.Common.Interfaces
{
	public interface IApplicationContext
	{
		string CurrentLoggedInUserName { get; set; }

		LogLevel LogLevel { get; set; }
	}
}
