using System;
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

namespace WPF_0.View.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private static int errorCount = 3;
        private DispatcherTimer BlockTimer = new DispatcherTimer();
        public LoginPage( )
        {
            InitializeComponent();
            // Check Login
            if (Properties.Settings.Default.EventTask != string.Empty)
                txb_Username.Text = Properties.Settings.Default.EventTask;
            // Event fot BanTimer
            BlockTimer.Tick += BlockTimer_Tick;
            // Check BanTimer
            if (( DateTime.Now - Properties.Settings.Default.Ban ).Ticks < new TimeSpan( 0, 0, 10 ).Ticks)
            {
                this.IsEnabled = false;
                BlockTimer.Start();
            }

        }

        // Event Ban Timer
        private void BlockTimer_Tick( object sender, EventArgs e )
        {
            if (( DateTime.Now - Properties.Settings.Default.Ban ).Ticks > new TimeSpan( 0, 0, 10 ).Ticks)
            {
                this.IsEnabled = true;
                errorCount = 0;
                BlockTimer.Stop();
            }

        }

        // Rember me
        public void RemberLoginUser( )
        {
            if (checkedRemeber.IsChecked == true)
            {
                Properties.Settings.Default.EventTask = txb_Username.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.EventTask = "";
                Properties.Settings.Default.Save();
            }
        }
        private void btn_Cancel_Click( object sender, RoutedEventArgs e )
        {
            Application.Current.Shutdown();
        }

        private void btn_Login_Click( object sender, RoutedEventArgs e )
        {
            if (txb_Username.Text == "thevckit" & psb_Password.Password == "1234")
            {
                MessageBox.Show( "Success!" );
                RemberLoginUser();
            }
            else
            {
                errorCount--;
                if (errorCount == 0)
                {
                    MessageBox.Show( $"Authorization error, you have {errorCount} attempts left. You are locked on 10 seconds.", "Error!",
                        MessageBoxButton.OK, MessageBoxImage.Error );
                    this.IsEnabled = false;
                    Properties.Settings.Default.Ban = DateTime.Now;
                    Properties.Settings.Default.Save();
                    BlockTimer.Start();
                }
                else
                {
                    MessageBox.Show( $"Authorization error, you have {errorCount} attempts left", "Error!",
                        MessageBoxButton.OK, MessageBoxImage.Error );
                }
            }
        }
    }
}
