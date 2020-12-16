using System.Windows;
using WPF_1.Views.Pages;
using WPF_1.Views.Pages.TextBox;

namespace WPF_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new TextBoxStyle());
        }
    }
}
