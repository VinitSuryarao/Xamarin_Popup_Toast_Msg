using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Popup_Toast_Message
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnPopUp_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Msg Titile", "Do u want to delete ?", "Ok", "No");
            if (result) {
                Msg.Text = "They want to Delete";
            } else {
                Msg.Text = "They don't want to Delete";
            }
        }
                
        private void btnToastShort_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IMessage>().LongTimeMessage("This is Long Toast Msg");
        }

        private void btnToastLong_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IMessage>().ShortTimeMessage("This is Short Toast Msg");
        }
    }
}
