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
    /// Interaction logic for ListeSayfasi.xaml
    /// </summary>
    public partial class ListeSayfasi : Page
    {
        List<Konut> konutlar;
        public ListeSayfasi(List<Konut> k)
        {
            InitializeComponent();
            konutlar = k;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DetaySayfasi detaySayfasi = new DetaySayfasi(this.KonutListView.SelectedItem);
            this.NavigationService.Navigate(detaySayfasi);
        }

        private void KonutListView_Loaded(object sender, RoutedEventArgs e)
        {
            this.KonutListView.Items.Clear();
            foreach (var konut in konutlar)
            {
                this.KonutListView.Items.Add(konut);

            }
        }
    }
}
