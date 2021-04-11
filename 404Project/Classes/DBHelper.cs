using _404Project.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404Project.Classes
{
    static class DBHelper
        

    {
        static private AdoKot context = new AdoKot();

        static public AdoKot GetContext()
        {
            return context;
        }

    }
}
