﻿#pragma checksum "..\..\..\..\..\Views\Pages\Metanit\ScrollViewer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F84ECDFC8E1A749B69FD8049DB2B8BE3DD21593ADE8110F37B6707C4D70E74D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using XAML_1.Views.Pages.Metanit;


namespace XAML_1.Views.Pages.Metanit {
    
    
    /// <summary>
    /// ScrollViewer
    /// </summary>
    public partial class ScrollViewer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Views\Pages\Metanit\ScrollViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scroll;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Views\Pages\Metanit\ScrollViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUp;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Views\Pages\Metanit\ScrollViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDown;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XAML-1;component/views/pages/metanit/scrollviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\Metanit\ScrollViewer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.scroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.btnUp = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\Views\Pages\Metanit\ScrollViewer.xaml"
            this.btnUp.Click += new System.Windows.RoutedEventHandler(this.btnUp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDown = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\Views\Pages\Metanit\ScrollViewer.xaml"
            this.btnDown.Click += new System.Windows.RoutedEventHandler(this.btnDown_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

