﻿using NewDemo.ViewModel.ChildViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddChildrenPage : ContentPage
    {
        public AddChildrenPage()
        {
            InitializeComponent();
            BindingContext = new AddChildrenViewModel();
        }
    }
}