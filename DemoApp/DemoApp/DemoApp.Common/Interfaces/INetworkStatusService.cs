using System;
using DemoApp.Common.Enums;

namespace DemoApp.Common.Interfaces
{	
	public interface INetworkStatusService
	{		
		event EventHandler NetworkStatusChanged;

		NetworkStatus NetworkStatus();
	}
}
