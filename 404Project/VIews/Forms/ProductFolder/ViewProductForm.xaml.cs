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
    /// Логика взаимодействия для ViewProductForm.xaml
    /// </summary>
    public partial class ViewProductForm : Window
    {

        public ViewProductForm(Product product)
        {
            InitializeComponent();
            this.DataContext = product;

        }
    }
}
