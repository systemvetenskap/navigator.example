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

namespace Navigering.Example
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : BasePage<Page2ViewModel>
    {
        public Page2()
        {
            InitializeComponent();
        }

        public Page2(Page2ViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }


    }
}
