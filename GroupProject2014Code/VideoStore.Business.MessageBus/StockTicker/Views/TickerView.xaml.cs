﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using StockTicker.Interfaces;

namespace StockTicker.Views
{
    /// <summary>
    /// Interaction logic for TickerView.xaml
    /// </summary>
    public partial class TickerView : UserControl
    {
        public TickerView()
        {
            InitializeComponent();
        }

        public ITickerViewModel ViewModel
        {
            get { return DataContext as ITickerViewModel; }
            set { DataContext = value; }
        }
    }
}
