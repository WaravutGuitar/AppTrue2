using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppTrue.Droid;
using Xamarin.Forms;
using DependencyAttribute = Xamarin.Forms.DependencyAttribute;

[assembly: Dependency(typeof(PhoneCall_Droid))]
namespace AppTrue.Droid
{
    public class PhoneCall_Droid : IPhoneCall
    {
        public void makeCall(string phoneNumber)
        {
            try
            {
                var URI = Android.Net.Uri.Parse(String.Format("tel:{0}", phoneNumber));
                var intent = new Intent(Intent.ActionCall, URI);
                Xamarin.Forms.Forms.Context.StartActivity(intent);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

        }
    }

}