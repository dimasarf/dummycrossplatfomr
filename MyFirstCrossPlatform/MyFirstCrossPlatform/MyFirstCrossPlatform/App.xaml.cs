using MyFirstCrossPlatform.EmployeeApp;
using MyFirstCrossPlatform.UserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstCrossPlatform
{
    public partial class App : Application
    {
        static EmployeeDatabase _employeeDb;
        static AccountDatabase _accountDb;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage() {BindingContext = new Account() });
        }

        public static AccountDatabase AccountDb
        {
            get
            {
                if (_accountDb == null)
                    _accountDb = new AccountDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalPath("Account.db3"));
                return _accountDb;
            }
        }
        public static EmployeeDatabase Database
        {
            get
            {
                if (_employeeDb == null)
                {
                    _employeeDb = new EmployeeDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalPath("Employee.db3"));
                }
                return _employeeDb;
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
