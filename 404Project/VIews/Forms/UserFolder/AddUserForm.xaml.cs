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
using System.Windows.Shapes;

namespace _404Project.VIews.Forms.UserFolder
{
    /// <summary>
    /// Логика взаимодействия для AddUserForm.xaml
    /// </summary>
    public partial class AddUserForm : Window
    {
        private User user = new User();
        public AddUserForm()
        {
            InitializeComponent();
            RoleCombo.ItemsSource = DBHelper.GetContext().Role.ToList();
            GenderBox.ItemsSource = DBHelper.GetContext().Gender.ToList();
            this.DataContext = user;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrEmpty(LastNameBox.Text))
            {
                errors.Append("Поле фамилии не заполнено");
            }
            if (String.IsNullOrEmpty(FirstNameBox.Text))
            {
                errors.Append("Поле имя не заполнено");
            }
            if (String.IsNullOrEmpty(PhoneBox.Text))
            {
                errors.Append("Поле телефона не заполнено");
            }
            if (String.IsNullOrEmpty(PasswordBox.Text))
            {
                errors.Append("Поле пароля не заполнено");
            }
            if (RoleCombo.SelectedItem == null)
            {
                errors.Append("Поле роли не заполнено");

            }

            //Валидация


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DBHelper.GetContext().User.Add(user);
            DBHelper.GetContext().SaveChanges();
            this.Close();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PhoneBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var text in e.Text)
            {
                if (!Char.IsDigit(text))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
