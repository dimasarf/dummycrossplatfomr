using MyFirstCrossPlatform.EmployeeApp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstCrossPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardMaster : ContentPage
    {
        public ListView ListView;
        
        public DashboardMaster()
        {
            InitializeComponent();
            
            BindingContext = new DashboardMasterViewModel();
            ListView = MenuItemsListView;
            
        }

        class DashboardMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DashboardMenuItem> MenuItems { get; set; }
            
            public DashboardMasterViewModel()
            {
                var imageurl = new Uri("https://image.ibb.co/d5Kmuk/user.png");
                
                MenuItems = new ObservableCollection<DashboardMenuItem>(new[]
                {
                    new DashboardMenuItem { Id = 0, Title = "Color Pallete", TargetType=typeof(GridTest), Icon="https://image.ibb.co/jWrYqQ/layers.png"},
                    new DashboardMenuItem { Id = 1, Title = "Home", TargetType = typeof(DashboardDetail), Icon ="https://image.ibb.co/gP6SH5/home.png"},
                    new DashboardMenuItem{Id = 2, Title ="Employee List", TargetType = typeof(EmployeeListPage), Icon="https://image.ibb.co/hQAnn5/clipboard.png"}
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }

       
    }
}