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
    /// Interaction logic for VillaDetay.xaml
    /// </summary>
    public partial class VillaDetay : Page
    {
        public VillaDetay()
        {
            InitializeComponent();
        }

        public VillaDetay(object data) : this()
        {
            this.DataContext = data;

        }
    }
}
