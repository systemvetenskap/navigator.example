﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NavigationService.Example.Models;

namespace NavigationService.Example
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : BasePage<Page1ViewModel>
    {
        public Page1()
        {
            InitializeComponent();
         //   DataContext = new Page1ViewModel();
        }

        
    }
}