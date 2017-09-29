using DemoApp.Common.Interfaces;
using DemoApp.Common.Logging;
using XLabs.Forms.Mvvm;

namespace DemoApp.Forms.ViewModels
{
	public class BaseViewModel : ViewModel
	{
		protected readonly INavigationService NavigationService;
		protected readonly ILogger Logger;

		public BaseViewModel(INavigationService navigationService, ILogger logger)
		{
			NavigationService = navigationService;
			Logger = logger;
		}
	}
}
