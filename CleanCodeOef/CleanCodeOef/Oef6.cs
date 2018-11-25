using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeOef
{
    class Oef6
    {

        //public enum Kleuren
        //{
        //    geel,
        //    groen,
        //    blauw
        //}
        //public class Product
        //{
        //    public string Naam { get; set; }
        //    public Kleuren Kleur { get; set; }
        //    public int Grootte { get; set; }
        //}

        //public class Filter
        //{
        //    public List<Product> FilterMethod(List<Product> lijst, Kleuren kleur)
        //    {
        //        List<Product> tmp = new List<Product>();
        //        foreach (var p in lijst)
        //        {
        //            if (p.Kleur == kleur)
        //                tmp.Add(p);
        //        }
        //        return tmp;
        //    }
        //}


        public enum Kleuren
        {
            geel,
            groen,
            blauw
        }
        public class Product
        {
            public string Naam { get; set; }
            public Kleuren Kleur { get; set; }
            public int Grootte { get; set; }
        }

        public class Filter
        {
            List<Product> tmp = new List<Product>();
            public List<Product> FilterMethod(List<Product> lijst, Kleuren kleur)
            { 
                foreach (var p in lijst)
                {
                    if (p.Kleur == kleur)
                        tmp.Add(p);
                }
                return tmp;
            }

            public List<Product> FilterMethod(List<Product> lijst, int grootte)
            {
                foreach (var p in lijst)
                {
                    if (p.Grootte == grootte)
                        tmp.Add(p);
                }
                return tmp;
            }

            public List<Product> FilterMethod(List<Product> lijst, Kleuren kleur, int grootte)
            {
                foreach (var p in lijst)
                {
                    if (p.Grootte == grootte && p.Kleur==kleur)
                        tmp.Add(p);
                }
                return tmp;
            }

        }


        public void main()
        {
            List<Product> pList = new List<Product>();
            pList.Add(new Product { Naam = "Bal", Kleur = Kleuren.geel, Grootte = 7 });
            pList.Add(new Product { Naam = "Potlood", Kleur = Kleuren.groen, Grootte = 12 });
            pList.Add(new Product { Naam = "Koffietas", Kleur = Kleuren.blauw, Grootte = 5 });
            pList.Add(new Product { Naam = "piano", Kleur = Kleuren.blauw, Grootte = 20 });

            List<Product> productListFilterd = new Filter().FilterMethod(pList, Kleuren.blauw);
            List<Product> productListFilterd2 = new Filter().FilterMethod(pList, 3);
            List<Product> productListFilterd3 = new Filter().FilterMethod(pList, Kleuren.blauw, 3);
        }








    }
}
