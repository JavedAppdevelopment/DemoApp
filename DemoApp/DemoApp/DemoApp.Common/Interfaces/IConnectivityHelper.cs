using System;
using System.Threading.Tasks;
using DemoApp.Common.Enums;

namespace DemoApp.Common.Interfaces
{
	public interface IConnectivityHelper
	{
		bool IsConnected { get; }

		NetworkStatus NetworkStatus { get; }

		Task InitiateCheckingAsync();

		void ContinueChecking();

		void PauseChecking();

		Task SetConnectionAsync();
	}
}
