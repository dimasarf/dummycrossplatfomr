using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyFirstCrossPlatform.EmployeeApp;
using Xamarin.Forms;
using MyFirstCrossPlatform.Droid;

[assembly : Dependency(typeof(LocalFileHelper))]
namespace MyFirstCrossPlatform.Droid
{
    
    public class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalPath(string FileName)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, FileName);
        }
    }
}