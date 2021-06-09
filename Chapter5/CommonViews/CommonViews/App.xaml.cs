﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CommonViews
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new DisplayAlertPage();
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
