﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPF_0.View.Pages;

namespace WPF_0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow( )
        {
            InitializeComponent();
            // Now time
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds( 1 );
            LiveTime.Tick += tick_Tick;
            LiveTime.Start();
            // Frame page Login
            frmObject.Navigate( new LoginPage() );
        }

        private void tick_Tick( object sender, EventArgs e )
        {
            txb_Time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
