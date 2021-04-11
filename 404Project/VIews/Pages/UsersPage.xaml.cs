using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms.UserFolder;
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
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            UsersListBox.ItemsSource = DBHelper.GetContext().User.ToList() ;

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            UsersListBox.ItemsSource = null;
            UsersListBox.ItemsSource = DBHelper.GetContext().User.ToList();

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var selected = (User)UsersListBox.SelectedItem;
            if (selected == null)
            {
                // error
                return;
            }
            EditUserForm editUserForm = new EditUserForm(selected);
            editUserForm.ShowDialog();
            UsersListBox.ItemsSource = null;
            UsersListBox.ItemsSource = DBHelper.GetContext().User.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UsersListBox.SelectedItem == null)
            {
                MessageBox.Show("Юзер не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DBHelper.GetContext().User.Remove((User)UsersListBox.SelectedItem);
            DBHelper.GetContext().SaveChanges();

            UsersListBox.ItemsSource = null;
            UsersListBox.ItemsSource = DBHelper.GetContext().User.ToList();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

       
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var lists = new List<User>();
            if (SearchBox.Text == "")
            {

                UsersListBox.ItemsSource = null;
                UsersListBox.ItemsSource = DBHelper.GetContext().User.ToList();
                return;
            }
            foreach (var user in DBHelper.GetContext().User.ToList())
            {
                var distance = Levenshtein.Distance(user.LastName, SearchBox.Text);
                if (distance <= 3)
                {
                    lists.Add(user);
                }
            }
            UsersListBox.ItemsSource = null;
            UsersListBox.ItemsSource = lists;
        }
    }
}
