using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms;
using _404Project.VIews.Forms.Comments;
using _404Project.VIews.Forms.ShopFolder;
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
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public ShopPage()
        {
            InitializeComponent();
            ShopListBox.ItemsSource = DBHelper.GetContext().Shop.ToList();
        }

        private void EditShopBtn(object sender, RoutedEventArgs e)
        {
            if (ShopListBox.SelectedItem == null)
            {
                MessageBox.Show("Магазин не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ShopEditForm shopEditForm = new ShopEditForm((Shop)ShopListBox.SelectedItem);
            shopEditForm.ShowDialog();
            ShopListBox.ItemsSource = null;

            ShopListBox.ItemsSource = DBHelper.GetContext().Shop.ToList();


        }

        private void AddShopBtn_Click(object sender, RoutedEventArgs e)
        {
            ShopAddForm shopAdd = new ShopAddForm();
            shopAdd.ShowDialog();
            ShopListBox.ItemsSource = null;
            ShopListBox.ItemsSource = DBHelper.GetContext().Shop.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ShopListBox.SelectedItem == null)
            {
                MessageBox.Show("Магазин не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DBHelper.GetContext().Shop.Remove((Shop)ShopListBox.SelectedItem);
            DBHelper.GetContext().SaveChanges();

            ShopListBox.ItemsSource = null;
            ShopListBox.ItemsSource = DBHelper.GetContext().Shop.ToList();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var lists = new List<Shop>();
            if (SearchBox.Text == "")
            {

                ShopListBox.ItemsSource = null;
                ShopListBox.ItemsSource = DBHelper.GetContext().Shop.ToList();
                return;
            }
            foreach (var item in DBHelper.GetContext().Shop.ToList())
            {
                var distance = Levenshtein.Distance(item.Name, SearchBox.Text);
                if (distance <= 3)
                {
                    lists.Add(item);
                }
            }
            ShopListBox.ItemsSource = null;
            ShopListBox.ItemsSource = lists;
        }
    }
}
