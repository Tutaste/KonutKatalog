using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Konut> konutlar = new List<Konut>();
            List<string> satirlar = File.ReadAllLines("..\\..\\Konutlar.txt").ToList();

            foreach (var satir in satirlar)
            {
                string[] degerler = satir.Split(',');

                switch (degerler[0])
                {
                    case "Villa":
                        Villa yeniVilla = new Villa();
                        yeniVilla.Alan = degerler[1];
                        yeniVilla.Fiyat = degerler[2];
                        yeniVilla.BahceAln = degerler[3];
                        yeniVilla.Garaj = degerler[4];
                        yeniVilla.Tip = degerler[5];
                        yeniVilla.Favori = bool.Parse(degerler[6]);
                        konutlar.Add(yeniVilla);
                        break;

                    case "Daire":
                        Daire yeniDaire = new Daire();
                        yeniDaire.Alan = degerler[1];
                        yeniDaire.Fiyat = degerler[2];
                        yeniDaire.Kat = degerler[3];
                        yeniDaire.Balkon = degerler[4];
                        yeniDaire.Asansor = degerler[5];
                        yeniDaire.Favori = bool.Parse(degerler[6]);
                        konutlar.Add(yeniDaire);
                        break;
                }
            }

            //MessageBox.Show(konutlar[1].ToString());

            ListeSayfasi sayfa = new ListeSayfasi(konutlar);
            this.NavigationService.Navigate(sayfa);
        }
    }
}
