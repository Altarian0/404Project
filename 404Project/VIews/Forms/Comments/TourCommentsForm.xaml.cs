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
    /// Логика взаимодействия для TourCommentsForm.xaml
    /// </summary>
    public partial class TourCommentsForm : Window
    {
        public TourCommentsForm(Tour tour)
        {
            InitializeComponent();
            CommentsListBox.ItemsSource = tour.TourComment.ToList();
            Tour = tour;
        }

        public Tour Tour { get; }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CommentsListBox.SelectedItem == null)
            {
                MessageBox.Show("Комментарий не выбран", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DBHelper.GetContext().TourComment.Remove((TourComment)CommentsListBox.SelectedItem);
            CommentsListBox.ItemsSource = null;
            CommentsListBox.SelectedItem = null;
            CommentsListBox.ItemsSource = Tour.TourComment.ToList();

        }
    }
}
