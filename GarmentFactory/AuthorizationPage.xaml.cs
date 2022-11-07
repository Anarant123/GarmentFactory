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

namespace GarmentFactory
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            WorkWindow workwindow = new WorkWindow(); //
            workwindow.Show();
            Window w = Window.GetWindow(this);
            if (w != null)
            {
                w.Close();
            }

        }

        private void btnToRegistr_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Registration.xaml", UriKind.Relative));
        }
    }
}
