
using MyFirstCrossPlatform.UserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstCrossPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            var account =  App.AccountDb.Login(txtUser.Text, txtPassword.Text);
            if (account.Id >= 1)
            {
                await Navigation.PushAsync(new Dashboard(txtUser.Text));
            }
            else
            {
                await DisplayAlert("Invalid Credentials", "Account not found", "Ok");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var account = (Account)BindingContext;
            await App.AccountDb.CreateAccount(account);
        }
    }
}