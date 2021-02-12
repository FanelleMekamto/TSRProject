using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoixProvince : ContentPage
    {
        int pickerProvinceIndex;
        public ChoixProvince()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            if(pickerProvinceIndex == 0)
            {
                await Navigation.PushAsync(new ContactPage());
            }
            else
            {
                await Navigation.PushAsync(new OtherProvince());
            }
        }

         private void pickerProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var statutSelectedIndex = pickerProvince.SelectedIndex;

            pickerProvinceIndex = pickerProvince.SelectedIndex;
        }
    }
}