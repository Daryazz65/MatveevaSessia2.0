using MatveevaSessia2.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MatveevaSessia2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static user6Entities _context;
        public static user6Entities GetContext()
        {
            if (_context == null)
            {
                _context = new user6Entities();
            }
            return _context;
        }
    }
}