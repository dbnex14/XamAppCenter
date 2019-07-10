using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace XamAppCenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnException_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("DINO: btnException_Clicked event triggered.");

            try
            {
                int a = Convert.ToInt32("Xamarin");
            }
            catch(Exception ex)
            {
                Crashes.TrackError(ex);
            }

            DisplayAlert("Title", "btnException_Clicked event has thrown and handled exception", "OK");

            Analytics.TrackEvent("DINO: btnException_Clicked has thrown and handled exception.");
        }
    }
}
