using _404Project.Classes;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
         
            var user = DBHelper.GetContext().User.Where(n => n.Phone == PhoneBox.Text && n.Password == PassBox.Password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Телефон или пароль не правильный", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (user.RoleId == 1)
            {
                NavigationService.Navigate(new MenuAdmin());

            }
        }


        private void PhoneBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var item in e.Text)
            {
                if (!Char.IsDigit(item))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
