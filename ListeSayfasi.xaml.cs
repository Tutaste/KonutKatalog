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

        public ListeSayfasi()
        {
            InitializeComponent();
        }

        public ListeSayfasi(List<Konut> konutlar) : this()
        {
            this.KonutListView.Items.Clear();
            foreach (var konut in konutlar)
            {
                this.KonutListView.Items.Add(konut);

            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.KonutListView.SelectedItem.GetType().Name == "Villa")
            {
                VillaDetay villaDetay = new VillaDetay(this.KonutListView.SelectedItem);
                this.NavigationService.Navigate(villaDetay);
            }
            else
            {
                DaireDetay daireDetay = new DaireDetay(this.KonutListView.SelectedItem);
                this.NavigationService.Navigate(daireDetay);
            }

        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            Konut knt = (Konut)this.KonutListView.SelectedItem;
            //MessageBox.Show(knt.Favori.ToString());
            
        }

    }
}
