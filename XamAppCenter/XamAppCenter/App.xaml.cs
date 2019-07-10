using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes; //not working on UWP

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamAppCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start(
                "android=b9a12e07-292d-4131-95b2-c5155f4adf88;" +
                "uwp=b324e455-d5f9-459c-b177-0a5dba61eade;;" +
                "ios=0a59b2b3-d83c-4fa5-bfc5-6728a6cdf853;"
                , typeof(Analytics), typeof(Crashes));
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
