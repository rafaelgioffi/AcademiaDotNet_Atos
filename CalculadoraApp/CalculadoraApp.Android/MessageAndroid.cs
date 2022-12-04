using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CalculadoraApp.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
namespace CalculadoraApp.Droid
{
    public class MessageAndroid : IMessage
    {      
        public void MsgCurta(string mensagem)
        {
            Toast.MakeText(Application.Context, mensagem, ToastLength.Short).Show();
        }
        public void MsgLonga(string mensagem)
        {
            Toast.MakeText(Application.Context, mensagem, ToastLength.Long).Show();
        }
    }
}