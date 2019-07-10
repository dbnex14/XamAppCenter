using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException("btnException_Clicked event is not implemented yet.");
        }
    }
}
