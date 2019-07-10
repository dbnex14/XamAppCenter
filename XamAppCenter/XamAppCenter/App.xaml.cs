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
                "uwp={Your UWP App secret here};" + 
                "ios={Your iOS App secret here}"
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
