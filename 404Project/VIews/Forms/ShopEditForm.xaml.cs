using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms.ProductFolder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _404Project.VIews.Forms
{
    /// <summary>
    /// Логика взаимодействия для ShopEditForm.xaml
    /// </summary>
    public partial class ShopEditForm : Window
    {
        private ObservableCollection<Product> selectedProducts = new ObservableCollection<Product>();

        public ShopEditForm(Shop localShop)
        {
            InitializeComponent();
            foreach (var product in localShop.Product)
            {
                selectedProducts.Add(product);
            }
            SelectedListBox.ItemsSource = selectedProducts;
            ProductListBox.ItemsSource = DBHelper.GetContext().Product.ToList();
            PlaceCombo.ItemsSource = DBHelper.GetContext().Place.ToList();

            this.shop = localShop;

            this.DataContext = this.shop;
        }

        public Shop shop = new Shop();

        private void SearchBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var products = new List<Product>();
            if (SearchBox.Text == "")
            {

                ProductListBox.ItemsSource = null;
                ProductListBox.ItemsSource = DBHelper.GetContext().Product.ToList();
                return;
            }
            foreach (var product in DBHelper.GetContext().Product.ToList())
            {
                var distance = Levenshtein.Distance(product.Name, SearchBox.Text);
                if (distance <= 3)
                {
                    products.Add(product);
                }
            }
            ProductListBox.ItemsSource = null;
            ProductListBox.ItemsSource = products;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListBox.SelectedItem == null)
            {
                return;
            }
            selectedProducts.Add((Product)ProductListBox.SelectedItem);
            ProductListBox.SelectedItem = null;

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedListBox.SelectedItem == null)
            {
                MessageBox.Show("Товар не выбран, выберите товар", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            selectedProducts.Remove((Product)SelectedListBox.SelectedItem);
            SelectedListBox.SelectedItem = null;
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListBox.SelectedItem == null)
            {
                //error
                MessageBox.Show("Товар не выбран, выберите товар", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ViewProductForm viewProductForm = new ViewProductForm((Product)ProductListBox.SelectedItem);
            viewProductForm.ShowDialog();
            ProductListBox.ItemsSource = null;
            ProductListBox.ItemsSource = DBHelper.GetContext().Product.ToList();

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (((Shop)this.DataContext) != null)
            {
                if (((Shop)this.DataContext).Id != 0)
                {
                    DBHelper.GetContext().Entry(this.DataContext).Reload();
                }
            }
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrEmpty(NameBox.Text))
            {
                errors.Append("Поле названии не заполнено");
            }
            if (PlaceCombo.SelectedItem == null)
            {
                errors.Append("Поле местоположения не заполнено");
            }
            if (PlaceCombo.SelectedItem == null)
            {
                errors.Append("Поле местоположения не заполнено");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            shop.Product = null;
            var noCopy = selectedProducts.Distinct<Product>();
            shop.Product = noCopy.ToList();
           
            DBHelper.GetContext().SaveChanges();
            this.Close();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void PhotoBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                PictureBox.Source = new BitmapImage(new Uri(PhotoLinkBox.Text));


            }
            catch (Exception)
            {
                MessageBox.Show("Ссылка некорректная", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            AddProductForm add = new AddProductForm();
            add.ShowDialog();
            ProductListBox.ItemsSource = null;
            ProductListBox.ItemsSource = DBHelper.GetContext().Product.ToList();
        }
    }
}
