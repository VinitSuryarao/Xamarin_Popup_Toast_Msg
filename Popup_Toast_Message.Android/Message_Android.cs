using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Popup_Toast_Message.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly:Dependency(typeof(Message_Android))]
namespace Popup_Toast_Message.Droid
{
    public class Message_Android : IMessage
    {
        public void LongTimeMessage(string Msg)
        {
            Toast.MakeText(Android.App.Application.Context, Msg, ToastLength.Long).Show();
        }

        public void ShortTimeMessage(string Msg)
        {
            Toast.MakeText(Android.App.Application.Context, Msg, ToastLength.Short).Show();
        }
    }
}