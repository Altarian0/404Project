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
    /// Логика взаимодействия для AddProductForm.xaml
    /// </summary>
    public partial class AddProductForm : Window
    {
        private Product product = new Product();
        private List<String> sources = new List<string>();
        public AddProductForm()
        {
            InitializeComponent();
            this.DataContext = product;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
            List<ProductImage> productImages = new List<ProductImage>();
            foreach (var source in sources)
            {
                ProductImage productImage = new ProductImage();
                productImage.Source = source;
                productImage.Product = product;

                productImages.Add(productImage);
            }
            product.ProductImage = productImages;
            DBHelper.GetContext().Product.Add(product);
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
                return;
            }
        }
    }
}
