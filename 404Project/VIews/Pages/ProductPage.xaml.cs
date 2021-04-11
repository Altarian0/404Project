using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms.Comments;
using _404Project.VIews.Forms.ProductFolder;
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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            ProductsView.ItemsSource = DBHelper.GetContext().Product.ToList();
        }

        private void EditBtn(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsView.SelectedItem == null)
            {
                MessageBox.Show("Товар не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var selected = (Product)ProductsView.SelectedItem;
        

            DBHelper.GetContext().Product.Remove(selected);

            DBHelper.GetContext().SaveChanges();

            ProductsView.ItemsSource = null;
            ProductsView.ItemsSource = DBHelper.GetContext().Product.ToList();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void EditShop_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsView.SelectedItem == null)
            {
                MessageBox.Show("Товар не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
       
            EditProductPage editProductPage = new EditProductPage((Product)ProductsView.SelectedItem);
            editProductPage.ShowDialog();
            ProductsView.ItemsSource = null;
            ProductsView.ItemsSource = DBHelper.GetContext().Product.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            ProductsView.ItemsSource = null;
            ProductsView.ItemsSource = DBHelper.GetContext().Product.ToList();
        }
        private void CommentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsView.SelectedItem == null)
            {
                MessageBox.Show("Товар не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ProductCommentsForm productComments = new ProductCommentsForm((Product)ProductsView.SelectedItem);
            productComments.ShowDialog();
            ProductsView.ItemsSource = null;
            ProductsView.ItemsSource = DBHelper.GetContext().Product.ToList();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var lists = new List<Product>();
            if (SearchBox.Text == "")
            {

                ProductsView.ItemsSource = null;
                ProductsView.ItemsSource = DBHelper.GetContext().Product.ToList();
                return;
            }
            foreach (var item in DBHelper.GetContext().Product.ToList())
            {
                var distance = Levenshtein.Distance(item.Name, SearchBox.Text);
                if (distance <= 3)
                {
                    lists.Add(item);
                }
            }
            ProductsView.ItemsSource = null;
            ProductsView.ItemsSource = lists;
        }
    }
}
