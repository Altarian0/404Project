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

namespace _404Project.VIews.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Page
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void ShopBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShopPage());

        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UsersPage());

        }

        private void ToursBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ToursPage());
        }

        private void ProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductPage());

        }

        private void PlaceBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlacesPage());

        }

        private void AttractionBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttractionPage());

        }

        private void AgentBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AgentPage());

        }
    }
}
