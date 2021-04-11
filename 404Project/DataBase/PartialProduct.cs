using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _404Project.DataBase
{
    partial class Product
    {
        public BitmapImage FirsImage
        {
            get
            {
                try
                {
                    var link = ProductImage.FirstOrDefault();
                if (link == null)
                {
                    return null;
                }
                
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.UriSource = new Uri(link.Source);
                    bi.EndInit();
                    return bi;
                }
                catch (Exception)
                {
                    return null;
                }
               
            }
        }
        public string RatingProduct
        {
            get
            {
                var comments = ProductComment.ToList();
                var sum = comments.Sum(n => n.Rating);
                if (comments.Count > 0)
                {
                    return Math.Round((double)sum / comments.Count(), 1) + "";
                }
                else
                {
                    return $"Рейтинга нет";
                }
            }
        }
    }
}
