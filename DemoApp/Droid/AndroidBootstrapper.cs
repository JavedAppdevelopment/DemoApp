﻿using System;
using Microsoft.Practices.Unity;
using DemoApp.Common.Interfaces;
using DemoApp.Forms.Droid.PlatformServices;
using DemoApp.Forms.Droid.Utils;
using DemoApp.Droid.Providers;
using DemoApp.Droid.Helpers;

namespace DemoApp.Forms.Droid
{
	public class AndroidBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<IAppConfig, AndroidAppConfig>(new TransientLifetimeManager());
			container.RegisterType<INetworkStatusService, AndroidNetworkStatusServices>(new HierarchicalLifetimeManager());
			container.RegisterType<IThreadExecutionProvider, ThreadExecutionProvider>(new TransientLifetimeManager());
			container.RegisterType<IStackFrameHelper, StackFrameHelper>(new ContainerControlledLifetimeManager());
			container.RegisterType<IPlatformService, PlatformServiceAndroid>(new ContainerControlledLifetimeManager());
			container.RegisterType<IDialogService, AndroidDialogService>(new TransientLifetimeManager());
			container.RegisterType<IAppAnalyticsProvider, RaygunAppAnalyticsProvider>(new TransientLifetimeManager());
			container.RegisterType<IFileSystemHelper, FileSystemHelper>(new TransientLifetimeManager());
			container.RegisterType<IEncryptionProvider, EncryptionProvider>(new TransientLifetimeManager());
		}
	}
}
