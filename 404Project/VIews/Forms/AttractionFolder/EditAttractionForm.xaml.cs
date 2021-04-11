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

namespace _404Project.VIews.Forms.AttractionFolder
{
    /// <summary>
    /// Логика взаимодействия для EditAttractionForm.xaml
    /// </summary>
    public partial class EditAttractionForm : Window
    {
        List<AttractionImage> AttractionImagess = new List<AttractionImage>();

        private Attraction editAttraction = new Attraction();
        private List<String> sources = new List<string>();
        public EditAttractionForm(Attraction attraction)
        {
            InitializeComponent();
            PlaceCombo.ItemsSource = DBHelper.GetContext().Place.ToList();
            editAttraction = attraction;
            this.DataContext = editAttraction;
            AttractionImagess = attraction.AttractionImage.ToList();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (((Attraction)this.DataContext) != null)
            {
                if (((Attraction)this.DataContext).Id != 0)
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
            if (String.IsNullOrEmpty(PlaceCombo.Text))
            {
                errors.Append("Поле местоположения не заполнено");
            }
            if (String.IsNullOrEmpty(DescriptionBox.Text))
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
                AttractionImage AttractionImages = new AttractionImage();
                AttractionImages.Source = source;
                AttractionImages.Attraction = editAttraction;

                AttractionImagess.Add(AttractionImages);
            }
            if (AttractionImagess.Count >= 0)
            {
                editAttraction.AttractionImage = AttractionImagess;
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
    }
}
