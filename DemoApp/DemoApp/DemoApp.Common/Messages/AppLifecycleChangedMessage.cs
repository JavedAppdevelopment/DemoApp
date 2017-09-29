using System;
using DemoApp.Common.Enums;
using DemoApp.Common.Interfaces;

namespace DemoApp.Common.Messages
{
	public class AppLifecycleChangedMessage : IMessage
	{
        public AppLifecycleChangedMessage(AppLifecycleState lifecyleState)
		{
			CurrentLifecyleState = lifecyleState;
		}

        public AppLifecycleState CurrentLifecyleState { get; set; }
	}
}
