using MyFirstCrossPlatform.EmployeeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstCrossPlatform
{
    public partial class App : Application
    {
        static EmployeeDatabase _db;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyFirstCrossPlatform.MainPage());
        }

        public static EmployeeDatabase Database
        {
            get
            {
                if (_db == null)
                {
                    _db = new EmployeeDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalPath("Employee.db3"));
                }
                return _db;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
