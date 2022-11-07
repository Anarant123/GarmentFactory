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
using System.Windows.Shapes;

namespace GarmentFactory
{
    /// <summary>
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void btnToOrderList_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("OrderListPage.xaml", UriKind.Relative));
        }

        private void btnToInventory_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("InventoryPage.xaml", UriKind.Relative));
        }
    }
}
