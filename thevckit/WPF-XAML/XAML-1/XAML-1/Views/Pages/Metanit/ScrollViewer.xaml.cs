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

namespace XAML_1.Views.Pages.Metanit
{
    /// <summary>
    /// Логика взаимодействия для ScrollViewer.xaml
    /// </summary>
    public partial class ScrollViewer : Page
    {
        public ScrollViewer( )
        {
            InitializeComponent();
        }

        private void btnUp_Click( object sender, RoutedEventArgs e )
        {
            scroll.LineUp();
        }

        private void btnDown_Click( object sender, RoutedEventArgs e )
        {
            scroll.LineDown();
        }
    }
}
