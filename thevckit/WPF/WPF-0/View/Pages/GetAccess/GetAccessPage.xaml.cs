using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WPF_0.ClassHelper;

namespace WPF_0.View.Pages.GetAccess
{
    /// <summary>
    /// Interaction logic for GetAccessPage.xaml
    /// </summary>
    public partial class GetAccessPage : Page
    {
        public GetAccessPage( )
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click( object sender, RoutedEventArgs e )
        {
            NavigationService.GoBack();
        }

        private void btn_SendData_Click( object sender, RoutedEventArgs e )
        {
            try
            {
                HelperObj.SendEmail(txb_FirstName.Text, txb_LastName.Text, txb_Username.Text, txb_Email.Text);
                MessageBox.Show( $"Password and login have been sent to the email address: {txb_Email.Text}", 
                    "It`s Done!", MessageBoxButton.OK, MessageBoxImage.Information );

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error );
            }
        }
    }
}
