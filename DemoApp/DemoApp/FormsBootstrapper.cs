﻿using Microsoft.Practices.Unity;
using DemoApp.Common.Interfaces;
using DemoApp.Forms.Services;
using DemoApp.Forms.ViewModels;
using DemoApp.Forms.Views;

namespace DemoApp.Forms
{
    public class FormsBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			RegisterTypes(container);
			RegisterViews(container);
		}

		private static void RegisterTypes(IUnityContainer container)
		{
			container.RegisterType<IApplicationContext, ApplicationContext>(new ContainerControlledLifetimeManager());
			container.RegisterType<INavigationService, NavigationService>(new ContainerControlledLifetimeManager());
			container.RegisterType<IMessagingService, MessagingService>(new ContainerControlledLifetimeManager());
		}

		private static void RegisterViewModels(IUnityContainer container)
		{
			container.RegisterType<FirstViewModel>(new TransientLifetimeManager());
		}

		private static void RegisterViews(IUnityContainer container)
		{
			container.RegisterType<FirstPage>(new TransientLifetimeManager());
			container.RegisterType<MenuPage>(new TransientLifetimeManager());
		}
	}
}

