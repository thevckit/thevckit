using System.Windows;

namespace XAML_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow( )
        {
            InitializeComponent();
            MainFrame.Navigate( new Views.Pages.Metanit.ComboBoxList() );
        }
    }
}
