﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            // MainPage = new LoginView();
            MainPage = new RegisterView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
