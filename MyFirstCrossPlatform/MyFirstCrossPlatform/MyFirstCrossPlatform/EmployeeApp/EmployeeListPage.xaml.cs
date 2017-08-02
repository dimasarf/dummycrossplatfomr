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
    public partial class EmployeeListPage : ContentPage
    {
        public EmployeeListPage()
        {
            InitializeComponent();

            
        }

        private async void Toolbar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmployeePage() { BindingContext = new Employee() });
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            EmployeeList.ItemsSource = await App.Database.GetEmployeesAsync();
        }

        private async void EmployeeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new EmployeePage() { BindingContext = e.SelectedItem as Employee});
            }
        }
    }
}