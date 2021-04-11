using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms;
using _404Project.VIews.Forms.Comments;
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
    /// Логика взаимодействия для ToursPage.xaml
    /// </summary>
    public partial class ToursPage : Page
    {
        public ToursPage()
        {
            InitializeComponent();
            TourListBox.ItemsSource = DBHelper.GetContext().Tour.ToList();
        }

      

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TourListBox.SelectedItem == null)
            {
                MessageBox.Show("Тур не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                DBHelper.GetContext().Tour.Remove((Tour)TourListBox.SelectedItem);
                DBHelper.GetContext().SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           

            TourListBox.ItemsSource = null;
            TourListBox.ItemsSource = DBHelper.GetContext().Tour.ToList();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddTursForm addTursForm = new AddTursForm();
            addTursForm.ShowDialog();
            TourListBox.ItemsSource = null;
            TourListBox.ItemsSource = DBHelper.GetContext().Tour.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TourListBox.SelectedItem == null)
            {
                MessageBox.Show("Тур не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            EditToursForm edit = new EditToursForm((Tour)TourListBox.SelectedItem);
            edit.ShowDialog();

            TourListBox.ItemsSource = null;
            TourListBox.ItemsSource = DBHelper.GetContext().Tour.ToList();
        }

        private void CommentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TourListBox.SelectedItem == null)
            {
                MessageBox.Show("Тур не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TourCommentsForm tour = new TourCommentsForm((Tour)TourListBox.SelectedItem);
            tour.ShowDialog();
            TourListBox.ItemsSource = null;
            TourListBox.ItemsSource = DBHelper.GetContext().Tour.ToList();




        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var lists = new List<Tour>();
            if (SearchBox.Text == "")
            {

                TourListBox.ItemsSource = null;
                TourListBox.ItemsSource = DBHelper.GetContext().Tour.ToList();
                return;
            }
            foreach (var item in DBHelper.GetContext().Tour.ToList())
            {
                var distance = Levenshtein.Distance(item.Name, SearchBox.Text);
                if (distance <= 3)
                {
                    lists.Add(item);
                }
            }
            TourListBox.ItemsSource = null;
            TourListBox.ItemsSource = lists;
        }
    }
}
