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

namespace XAML_2.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxWithPlaceHolder.xaml
    /// </summary>
    public partial class TextBoxWithPlaceHolder : UserControl
    {
        public TextBoxWithPlaceHolder( )
        {
            InitializeComponent();
        }
        //public string PlaceHolder {
        //    get { return (int)GetValue( MyPropertyProperty ); }
        //    set { SetValue( MyPropertyProperty, value ); };
        //}
        //public static readonly DependencyProperty PlaceHolderProperty = DependencyProperty.Register( "PlaceHolder", typeof( string ) )
    }
}
