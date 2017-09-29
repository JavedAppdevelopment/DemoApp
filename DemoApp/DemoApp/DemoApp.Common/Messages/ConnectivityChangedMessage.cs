using System;
using DemoApp.Common.Interfaces;

namespace DemoApp.Common.Messages
{
	public class ConnectivityChangedMessage : IMessage
	{
		public ConnectivityChangedMessage(bool isConnected)
		{
			IsConnected = isConnected;
		}

		public bool IsConnected { get; private set; }
	}
}
