using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using WPF_0.Context;
using WPF_0.View.Pages.GetAccess;

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
            var currentUser = dbContext.db.SignIns.FirstOrDefault( item => item.Username == txb_Username.Text &&
             item.Password == item.Password );
            if (currentUser != null)
            {
                switch (currentUser.IDRole)
                {
                    case "A":
                        MessageBox.Show( "Success!" );
                        RemberLoginUser();
                        break;
                }
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

        private void btn_GetAccess_Click( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate( new GetAccessPage() );
        }
    }
}
