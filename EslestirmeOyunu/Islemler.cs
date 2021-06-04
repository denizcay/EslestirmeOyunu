using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EslestirmeOyunu
{
    public static class Islemler
    {
        static Random rast = new Random();
        public static void Karistir<T>(IList<T> list)
        {
            T gecici;
            int indeks;
            for (int i = 0; i < list.Count - 1; i++)
            {
                indeks = rast.Next(i, list.Count);
                gecici = list[i];
                list[i] = list[indeks];
                list[indeks] = gecici;
            }
        }
    }
}
