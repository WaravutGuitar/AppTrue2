using AppTrue.Models;
using AppTrue.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTrue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManuMain : TabbedPage
    {
        public ManuMain()
        {
            InitializeComponent();
            Test();
            // FillList();
        }


        public async void Test()
        {
            var Category = await NetworkService.GetCategory();

            for (int i = 0; i < Category.Count; i++)
            {
                var data = Category.ElementAt(i);
                var result = await NetworkService.GetPronet(data._id);
                CardViewTemplate caView = new CardViewTemplate();
                var con = new ContentPage
                {

                    Title = data.title,
                    Content = new StackLayout
                    {
                        Children =
                    {
                        new ListView
                        {
                            HasUnevenRows = true,
                            ItemsSource = result,
                            ItemTemplate = new DataTemplate(() =>
                            {
                                 return new ViewCell
                                 {
                                       View = new CardViewTemplate
                                       {

                                       }
                                 };
                             })
                        }
}
                    }
                };

                Children.Add(con);
            }



        }



        async void FillList()
        {
            //var result = await NetworkService.GetPronet("5d924e37755fb01861a81c49");


            //var Category = await NetworkService.GetCategory();
            //Tap.ItemsSource = Category;
            // Emplist.ItemsSource = result;
            //var result2 = await NetworkService.GetPronet("5d924e43755fb01861a81c4a");
            //Emplist2.ItemsSource = result2;
            //var result3 = await NetworkService.GetPronet("5d924e48755fb01861a81c4b");
            //Emplist3.ItemsSource = result3;

        }


        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ListView btn = (ListView)sender;
            //var id = e.SelectedItem;
            var device = e.SelectedItem as pronet;
            string id = device._id;
            //int clubid = (int)btn.CommandParameter;
            await Navigation.PushAsync(new Detail(id));
            ////await Navigation.PushAsync(new DetailedClub(clubid));
        }
    }
}