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

namespace _404Project.VIews.Forms.Comments
{
    /// <summary>
    /// Логика взаимодействия для ProductCommentsForm.xaml
    /// </summary>
    public partial class ProductCommentsForm : Window
    {
        public ProductCommentsForm(Product product)
        {
            InitializeComponent();
            CommentsListBox.ItemsSource = product.ProductComment.ToList();
            Product = product;
        }

        public Product Product { get; }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CommentsListBox.SelectedItem == null)
            {
                MessageBox.Show("Комментарий не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DBHelper.GetContext().ProductComment.Remove((ProductComment)CommentsListBox.SelectedItem);
            CommentsListBox.ItemsSource = null;
            CommentsListBox.SelectedItem = null;

            CommentsListBox.ItemsSource = Product.ProductComment.ToList();

        }
    }
}
