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
    /// Логика взаимодействия для InventoryPage.xaml
    /// </summary>
    public partial class InventoryPage : Page
    {
        public InventoryPage()
        {
            InitializeComponent();
        }

        private void btnCompareData_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int flag = random.Next(0,100);
            if (flag < 20)
            {
                MessageBox.Show("Инвентаризация проведена неверно, отличия больше 20%.");
            }
            else
            {
                MessageBox.Show("Отчет об инвентаризации отправлен на принтер.");
            }
        }

        private void btnAddTextile_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("AddTextilePage.xaml", UriKind.Relative));
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("AddProductPage.xaml", UriKind.Relative));
        }

        private void btnAddAccessories_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("AddAccessoriesPage.xaml", UriKind.Relative));
        }
    }
}
