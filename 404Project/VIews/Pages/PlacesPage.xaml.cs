using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms.PlaceFolder;
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
    /// Логика взаимодействия для PlacesPage.xaml
    /// </summary>
    public partial class PlacesPage : Page
    {
        public PlacesPage()
        {
            InitializeComponent();
            PlacesGrid.ItemsSource = DBHelper.GetContext().Place.ToList();
        }
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PlacesGrid.SelectedItem == null)
            {
                MessageBox.Show("Местоположение не выбрано", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DBHelper.GetContext().Place.Remove((Place)PlacesGrid.SelectedItem);
            DBHelper.GetContext().SaveChanges();

            PlacesGrid.ItemsSource = null;
            PlacesGrid.ItemsSource = DBHelper.GetContext().Place.ToList();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPlaceForm addTursForm = new AddPlaceForm();
            addTursForm.ShowDialog();
            PlacesGrid.ItemsSource = null;
            PlacesGrid.ItemsSource = DBHelper.GetContext().Place.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PlacesGrid.SelectedItem == null)
            {
                MessageBox.Show("Местоположение не выбрано", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            EditPlaceForm edit = new EditPlaceForm((Place)PlacesGrid.SelectedItem);
            edit.ShowDialog();

            PlacesGrid.ItemsSource = null;
            PlacesGrid.ItemsSource = DBHelper.GetContext().Place.ToList();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var lists = new List<Place>();
            if (SearchBox.Text == "")
            {

                PlacesGrid.ItemsSource = null;
                PlacesGrid.ItemsSource = DBHelper.GetContext().Place.ToList();
                return;
            }
            foreach (var item in DBHelper.GetContext().Place.ToList())
            {
                var distance = Levenshtein.Distance(item.Name, SearchBox.Text);
                if (distance <= 3)
                {
                    lists.Add(item);
                }
            }
            PlacesGrid.ItemsSource = null;
            PlacesGrid.ItemsSource = lists;
        }
    }
}
