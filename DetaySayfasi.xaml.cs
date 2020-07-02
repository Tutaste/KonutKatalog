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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Katalog
{
    /// <summary>
    /// Interaction logic for DetaySayfasi.xaml
    /// </summary>
    public partial class DetaySayfasi : Page
    {
        public DetaySayfasi()
        {
            InitializeComponent();
        }

        public DetaySayfasi(object data) : this()
        {
            this.DataContext = data;
            
        }
    }
}
