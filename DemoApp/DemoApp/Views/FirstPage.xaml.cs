﻿using System;
using System.Collections.Generic;
using DemoApp.Forms.ViewModels;
using Xamarin.Forms;

namespace DemoApp.Forms.Views
{
	public partial class FirstPage : ContentPage
	{
		private readonly FirstViewModel _firstViewModel;

		public FirstPage(FirstViewModel firstViewModel)
		{
			InitializeComponent();
			BindingContext = firstViewModel;
			_firstViewModel = firstViewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_firstViewModel.OnAppear();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			_firstViewModel.OnDisappear();
		}
	}
}
