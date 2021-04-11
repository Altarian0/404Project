using _404Project.Classes;
using _404Project.DataBase;
using _404Project.VIews.Forms.AttractionFolder;
using _404Project.VIews.Forms.PlaceFolder;
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
    /// Логика взаимодействия для AddTursForm.xaml
    /// </summary>
    public partial class AddTursForm : Window
    {
        ObservableCollection<Attraction> attractions = new ObservableCollection<Attraction>();
        private Tour tour = new Tour();
        public AddTursForm()
        {
            InitializeComponent();
            StartPlace.ItemsSource = DBHelper.GetContext().Place.ToList(); 
            EndPlace.ItemsSource = DBHelper.GetContext().Place.ToList();
            AgentCombo.ItemsSource = DBHelper.GetContext().Agent.ToList();

            this.DataContext = tour;
        }

        private  void AttractionCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = (Attraction)AttractionCombo.SelectedItem;

            if (selected != null)
            {
                if (selected.AttractionImage != null)
                {
                
                    ImageBox.Source =  new BitmapImage(new Uri(selected.AttractionImage.FirstOrDefault().Source));
                }
            }
        }

        

        private void AddAttractionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AttractionCombo.SelectedItem == null)
            {
                MessageBox.Show("Нечего не выбрано", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var selected = (Attraction)AttractionCombo.SelectedItem;
            attractions.Add(selected);
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrEmpty(NameBox.Text))
            {
                errors.AppendLine("Поле названии не заполнено");
            }
            if (String.IsNullOrEmpty(PriceBox.Text))
            {
                errors.AppendLine("Поле цены не заполнено");
            }
            if (String.IsNullOrEmpty(DescritionBox.Text))
            {
                errors.AppendLine("Поле описании не заполнено");
            }
            if (StartDate.SelectedDate == null)
            {
                errors.AppendLine("Поле даты начало не заполнено");
            }
            if (EndDate.SelectedDate == null)
            {
                errors.AppendLine("Поле даты конца не заполнено");
            }
            if (attractions.Count == 0)
            {
                errors.AppendLine("Достопримечательности не привязаны, привяжите хотя бы одну");
            }
            if (StartPlace.SelectedItem == null)
            {
                errors.AppendLine("Поле для исходной строчки маршрута не заполнено");
            }
            if (EndPlace.SelectedItem == null)
            {
                errors.AppendLine("Поле для конечной строчки маршрута не заполнено");
            }
            if (String.IsNullOrEmpty(DescritionBox.Text))
            {
                errors.AppendLine("Поле описании не заполнено");
            }
            //Валидация

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            tour.Attraction = attractions;
            DBHelper.GetContext().Tour.Add(tour);
            DBHelper.GetContext().SaveChanges();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();

        }

        private void PriceBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var text in e.Text)
            {
                if (!Char.IsDigit(text))
                {
                    e.Handled = true;
                }
            }
        }

        private void EndPlace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EndPlace.SelectedItem == null)
            {
                return;
            }
            var selected = (Place)EndPlace.SelectedItem;
            AttractionCombo.ItemsSource = null;
            AttractionCombo.IsEnabled = true;
            AttractionCombo.ItemsSource = selected.Attraction.ToList();
            attractions = new ObservableCollection<Attraction>();
        }

        private void NewAttractionBtn_Click(object sender, RoutedEventArgs e)
        {
            AddAttractionForm addAttractionForm = new AddAttractionForm();
            addAttractionForm.ShowDialog();
            var selected = (Place)EndPlace.SelectedItem;

            if (EndPlace.SelectedItem == null)
            {
                AttractionCombo.ItemsSource = null;
                AttractionCombo.ItemsSource = selected.Attraction.ToList();
                return;

            }
            AttractionCombo.SelectedItem = null;
            AttractionCombo.ItemsSource = null;
            AttractionCombo.ItemsSource = selected.Attraction.ToList();

        }

        private void NewPlaceBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPlaceForm addTursForm = new AddPlaceForm();
            addTursForm.ShowDialog();
            StartPlace.ItemsSource = null;
            EndPlace.ItemsSource = null;
            StartPlace.ItemsSource = DBHelper.GetContext().Place.ToList();
            EndPlace.ItemsSource = DBHelper.GetContext().Place.ToList();
        }
    }
}
