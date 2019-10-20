using Android.Content;
using AppTrue.Models;
using AppTrue.Service;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace AppTrue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        string titleH = "";
        string titleD = "";
        string tel = "";
        public Detail(string id)
        {
            InitializeComponent();
            FillList(id);
        }

        async void FillList(string id)
        {
            var result = await NetworkService.GetPronetDetail(id);
            Header.Text = result.title;
            detail.Text = result.detail;
            btn_click.Text = result.tel;
            titleH = result.category.title;
            titleD = "ต้องการสมัคร " + result.title + " ?";
            tel = result.tel;



        }

        private async void BtnCall_Click(object sender, EventArgs e)
        {
            var ans = await DisplayAlert(titleH, titleD, "Ok", "Cancel");
            if (ans == true)
            {
                Boolean success = false;
                // DependencyService.Get<IPhoneCall>().makeCall("123456");
                //Device.OpenUri(new Uri(String.Format("tel:{0}", "+49000000")));
                
                var uri = Android.Net.Uri.Parse($"tel:"+ tel + "");
                var intent = new Intent(Intent.ActionDial, uri);

                //var URI = Android.Net.Uri.Parse(String.Format("tel:{0}", "+49000000"));
                //var intent = new Intent(Intent.ActionCall, URI);  
                Android.App.Application.Context.StartActivity(intent);
                //var PhoneCallTask = CrossMessaging.Current.PhoneDialer;
                ////if (PhoneCallTask.CanMakePhoneCall)
                //    PhoneCallTask.MakePhoneCall("123456");
            }
            else
            {
                //false conditon
            }

        }

   
    }
}