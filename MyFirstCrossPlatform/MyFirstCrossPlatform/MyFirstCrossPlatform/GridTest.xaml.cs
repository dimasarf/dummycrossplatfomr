﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstCrossPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridTest : ContentPage
    {
        public GridTest()
        {
            InitializeComponent();
        }

        private async void BoxView_Focused(object sender, FocusEventArgs e)
        {
            
        }
    }
}