// Updated by XamlIntelliSenseFileGenerator 12/18/2020 1:10:00 AM
#pragma checksum "..\..\..\CustomControls\TextBoxWithPlaceHolder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A21623CA88FEBA8C11FA1A9CE7EE315721439C8DCFB887C6C70DCA4674B097A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using XAML_2.CustomControls;


namespace XAML_2.CustomControls
{


    /// <summary>
    /// TextBoxWithPlaceHolder
    /// </summary>
    public partial class TextBoxWithPlaceHolder : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 91 "..\..\..\CustomControls\TextBoxWithPlaceHolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute( "Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields" )]
        internal System.Windows.Controls.TextBlock title;

#line default
#line hidden


#line 95 "..\..\..\CustomControls\TextBoxWithPlaceHolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute( "Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields" )]
        internal System.Windows.Controls.TextBox email;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute( "PresentationBuildTasks", "4.0.0.0" )]
        public void InitializeComponent( )
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri( "/XAML-2;component/customcontrols/textboxwithplaceholder.xaml", System.UriKind.Relative );

#line 1 "..\..\..\CustomControls\TextBoxWithPlaceHolder.xaml"
            System.Windows.Application.LoadComponent( this, resourceLocater );

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute( "PresentationBuildTasks", "4.0.0.0" )]
        [System.ComponentModel.EditorBrowsableAttribute( System.ComponentModel.EditorBrowsableState.Never )]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute( "Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes" )]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute( "Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity" )]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute( "Microsoft.Performance", "CA1800:DoNotCastUnnecessarily" )]
        void System.Windows.Markup.IComponentConnector.Connect( int connectionId, object target )
        {
            switch (connectionId)
            {
                case 1:
                    this._this = ( (XAML_2.CustomControls.TextBoxWithPlaceHolder)( target ) );
                    return;
                case 2:
                    this.title = ( (System.Windows.Controls.TextBlock)( target ) );
                    return;
                case 3:
                    this.email = ( (System.Windows.Controls.TextBox)( target ) );
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.UserControl _this;
    }
}

