﻿using RELPREMEE.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RELPREMEE
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<INavigationService, NavigationService>();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
