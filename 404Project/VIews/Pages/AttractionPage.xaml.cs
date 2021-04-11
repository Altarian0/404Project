using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms.AttractionFolder;
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
    /// Логика взаимодействия для AttractionPage.xaml
    /// </summary>
    public partial class AttractionPage : Page
    {
        public AttractionPage()
        {
            InitializeComponent();
            AttractionListBox.ItemsSource = DBHelper.GetContext().Attraction.ToList();
        }
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AttractionListBox.SelectedItem == null)
            {
                MessageBox.Show("Товар не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var selected = (Attraction)AttractionListBox.SelectedItem;


            DBHelper.GetContext().Attraction.Remove(selected);

            DBHelper.GetContext().SaveChanges();

            AttractionListBox.ItemsSource = null;
            AttractionListBox.ItemsSource = DBHelper.GetContext().Attraction.ToList();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void EditShop_Click(object sender, RoutedEventArgs e)
        {
            if (AttractionListBox.SelectedItem == null)
            {
                MessageBox.Show("Товар не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //EditProductPage editProductPage = new EditProductPage((Attraction)AttractionListBox.SelectedItem);
            //editProductPage.ShowDialog();
            //AttractionListBox.ItemsSource = null;
            //AttractionListBox.ItemsSource = DBHelper.GetContext().Product.ToList();
        }

       

        private void EditShopBtn(object sender, RoutedEventArgs e)
        {
            if (AttractionListBox.SelectedItem == null)
            {
                MessageBox.Show("Товар не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var selected = (Attraction)AttractionListBox.SelectedItem;

            EditAttractionForm addProductForm = new EditAttractionForm(selected);
            addProductForm.ShowDialog();

            DBHelper.GetContext().SaveChanges();

            AttractionListBox.ItemsSource = null;
            AttractionListBox.ItemsSource = DBHelper.GetContext().Attraction.ToList();
        }

        private void AddShopBtn_Click(object sender, RoutedEventArgs e)
        {
            AddAttractionForm addProductForm = new AddAttractionForm();
            addProductForm.ShowDialog();
            AttractionListBox.ItemsSource = null;
            AttractionListBox.ItemsSource = DBHelper.GetContext().Attraction.ToList();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var lists = new List<Attraction>();
            if (SearchBox.Text == "")
            {

                AttractionListBox.ItemsSource = null;
                AttractionListBox.ItemsSource = DBHelper.GetContext().Attraction.ToList();
                return;
            }
            foreach (var item in DBHelper.GetContext().Attraction.ToList())
            {
                var distance = Levenshtein.Distance(item.Name, SearchBox.Text);
                if (distance <= 3)
                {
                    lists.Add(item);
                }
            }
            AttractionListBox.ItemsSource = null;
            AttractionListBox.ItemsSource = lists;
        }
    }
}
