using _404Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _404Project.DataBase
{
    partial class Tour
    {
        public string Marshrut
        {
            get
            {
                return $"{Place.Name} --> {Place1.Name}";
            }
        }

        public string RatingTour
        {
            get
            {
                var comments = TourComment.ToList();
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
        public BitmapImage FirsImage
        {
            get
            {
                    AttractionImage link;
                try
                {
                    if (Attraction.Count == 0)
                    {
                        return null;

                    }
                    link = Attraction.FirstOrDefault().AttractionImage.FirstOrDefault();
                    if (link == null)
                    {
                        return null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
              
                try
                {
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
    }
}
