using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404Project.DataBase
{
    partial class Attraction
    {
        public AttractionImage Image => AttractionImage.FirstOrDefault();
        public string AttractionPlace 
        {
            get
            {
                if (Place != null)
                {
                   return $"{Place.Name}-{Name}";
                }
                return null;

            }
        }

    }
}
