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

namespace _404Project.VIews.Forms.ProductFolder
{
    /// <summary>
    /// Логика взаимодействия для EditProductPage.xaml
    /// </summary>
    public partial class EditProductPage : Window
    {
        private Product editProduct = new Product();
        private List<String> sources = new List<string>();

        public EditProductPage(Product product)
        {
            InitializeComponent();
            editProduct = product;
            this.DataContext = editProduct;

        }
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (((Product)this.DataContext) != null)
            {
                if (((Product)this.DataContext).Id != 0)
                {
                    DBHelper.GetContext().Entry(this.DataContext).Reload();
                }
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (String.IsNullOrEmpty(Name.Text))
            {
                errors.Append("Поле названии не заполнено");
            }
            if (String.IsNullOrEmpty(PriceBox.Text))
            {
                errors.Append("Поле цены не заполнено");
            }
            if (String.IsNullOrEmpty(Description.Text))
            {
                errors.Append("Поле описании не заполнено");
            }

            //Валидация


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            foreach (var source in sources)
            {
                ProductImage productImage = new ProductImage();
                productImage.Source = source;
                productImage.Product = editProduct;
                DBHelper.GetContext().ProductImage.Add(productImage);
                DBHelper.GetContext().SaveChanges();
            }
            DBHelper.GetContext().SaveChanges();
            this.Close();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AddImageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(ImageLinkBox.Text))
            {
                return;
            }
            sources.Add(ImageLinkBox.Text);
            MessageBox.Show("Картинка добавлена", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ImageLinkBtn_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                PictureBox.Source = new BitmapImage(new Uri(ImageLinkBox.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Ссылка некорректная", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                ImageLinkBox.Text = "";
                return;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
          
        }
    }
}
