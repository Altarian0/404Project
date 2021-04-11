using _404Project.Classes;
using _404Project.DataBase;
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
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        User user = new User();
        public RegisterPage()
        {
            InitializeComponent();
            this.DataContext = user;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrEmpty(LastNameBox.Text))
            {
                errors.Append("Поле фамилии не заполнено");
            }




            //Валидация


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
         
                DBHelper.GetContext().User.Add(user);
                DBHelper.GetContext().SaveChanges();
           
           
        }
    }
}
