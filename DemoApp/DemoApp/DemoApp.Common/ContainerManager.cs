﻿using System;
using Microsoft.Practices.Unity;

namespace DemoApp.Common
{	
	public static class ContainerManager
	{
		public static IUnityContainer Container { get; private set; }

		public static void Initialize()
		{
			Container = new UnityContainer();
		}
	}
}
