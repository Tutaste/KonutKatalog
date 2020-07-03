using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{      
    public class ReadWrite
    {
        public static List<Konut> konutlar = new List<Konut>();

        public static void KonutlarYenile()
        {
            konutlar.Clear();

            List<string> satirlar = File.ReadAllLines("..\\..\\Konutlar.txt").ToList();

            for (int x = 0; x < satirlar.Count; x++)
            {
                var satir = satirlar[x];
                string[] degerler = satir.Split(',');

                switch (degerler[0])
                {
                    case "Villa":
                        Villa yeniVilla = new Villa();
                        yeniVilla.SatirNo = x;

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
                        yeniDaire.SatirNo = x;

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
        }

        public static void KonutlarKaydet()
        {
            String datastr = "";

            foreach (var konut in konutlar)
            {
                switch (konut.KonutTipi)
                {
                    case "Villa":
                        Villa yeniVilla = (Villa)konut;
                        datastr += konut.KonutTipi + "," + yeniVilla.Alan + "," + yeniVilla.Fiyat + "," + yeniVilla.BahceAln + "," + yeniVilla.Garaj + "," + yeniVilla.Tip + "," + yeniVilla.Favori + Environment.NewLine;
                        break;

                    case "Daire":
                        Daire yeniDaire = (Daire)konut;
                        datastr += konut.KonutTipi + "," + yeniDaire.Alan + "," + yeniDaire.Fiyat + "," + yeniDaire.Kat + "," + yeniDaire.Balkon + "," + yeniDaire.Asansor + "," + yeniDaire.Favori + Environment.NewLine;
                        break;
                }
            }
            
            
            File.WriteAllText("..\\..\\Konutlar.txt", datastr);
            
        }


    }
}
