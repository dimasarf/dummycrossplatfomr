using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstCrossPlatform.EmployeeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeePage : ContentPage
    {
        public EmployeePage()
        {
            InitializeComponent();          
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //var gesture = sender as TapGestureRecognizer;
            //var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });
            //if (photo != null)
            //    empImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
            await DisplayAlert("Hello", "Fuck Yourself!", ":((");
           
        }

        private bool IsEmpty()
        {
            if (txtName.Text.Length == 0)
                return false;
            else
                return true;
        }

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            var personItem = (Employee)BindingContext;
            await App.Database.SaveEmployeeAsync(personItem);
            await Navigation.PopAsync();
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            var image = new Intent();
            
            await Navigation.PopAsync();
        }
    }
}