using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Com.EverlyticPush;

namespace EverlyticPushXamarinSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            // Copy and paste your Everlytic push notification configuration 
            // string into the parameter below.

            Everlytic.Instance
                //.SetTestMode(true) // Optional. This prevents HTTP calls to Everlytic, for test purposes only.
                .Initialize("<your configuration here>");
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
