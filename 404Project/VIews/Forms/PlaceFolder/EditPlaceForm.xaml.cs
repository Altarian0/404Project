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

namespace _404Project.VIews.Forms.PlaceFolder
{
    /// <summary>
    /// Логика взаимодействия для EditPlaceForm.xaml
    /// </summary>
    public partial class EditPlaceForm : Window
    {
        private Place editPlace = new Place();
        public EditPlaceForm(Place place)
        {
            InitializeComponent();
            editPlace = place;
            this.DataContext = editPlace;
        }
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (((Place)this.DataContext) != null)
            {
                if (((Place)this.DataContext).Id != 0)
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
            if (String.IsNullOrEmpty(Latidute.Text))
            {
                errors.Append("Широта не установлена");
            }
            if (String.IsNullOrEmpty(LongitudeBox.Text))
            {
                errors.Append("Долгота не установлена");
            }

            //Валидация


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DBHelper.GetContext().SaveChanges();
            this.Close();
            MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
