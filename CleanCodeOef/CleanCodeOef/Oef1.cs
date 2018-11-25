using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeOef
{
    class Oef1
    {

        //public abstract class Shape
        //{
        //    public abstract double Opp();
        //}
        //class Circle : Shape
        //{
        //    public int straal;
        //    public Circle(int s)
        //    {
        //        straal = s;
        //    }
        //    public override double Opp()
        //    {
        //        return straal * straal * Math.PI;
        //    }
        //}
        //class Square : Shape
        //{
        //    public int lengte;
        //    public Square(int l)
        //    {
        //        lengte = l;
        //    }
        //    public override double Opp()
        //    {
        //        return lengte * lengte;
        //    }
        //}
        //class OppBerekenaar
        //{
        //    List<Shape> lijst;
        //    public OppBerekenaar()
        //    {
        //        lijst = new List<Shape>();
        //    }
        //    public void VoegToe(Shape s)
        //    {
        //        lijst.Add(s);
        //    }
        //    private double Sum()
        //    {
        //        double total = 0,;
        //        foreach (Shape s in lijst)
        //        {
        //            total += s.Opp();
        //        }
        //        return total;
        //    }
        //    public string Output()
        //    {
        //        return "<h1> Totale som = " + Sum() + " </h1> ";
        //    }
        //}

        // 1 Klasse met meerdere reposibilities


       

        public abstract class Shape
        {
            public abstract double Opp();
        }

        class Circle : Shape
        {
            public int straal;
            public Circle(int s)
            {
                straal = s;
            }
            public override double Opp()
            {
                return straal * straal * Math.PI;
            }
        }
        class Square : Shape
        {
            public int lengte;
            public Square(int l)
            {
                lengte = l;
            }
            public override double Opp()
            {
                return lengte * lengte;
            }
        }

        class Driehoek : Shape
        {
            public int basis;
            public int loodlijn;

            public Driehoek(int b , int l)
            {
                basis = b;
                loodlijn = l;
                
            }
            public override double Opp()
            {
                return (basis * loodlijn) / 2;
            }
        }

        public interface IOutput {
            string Data(String s);
        }

        public abstract class HtmlOutput: IOutput
        {
            public string Data(string s)
            {
                return "<h1>" + s + "</h1>";
            }
        }



        class OppBerekenaar
        {
            List<Shape> lijst;

            public OppBerekenaar()
            {
                lijst = new List<Shape>();
            }
            public void VoegToe(Shape s)
            {
                lijst.Add(s);
            }
            private double Sum()
            {
                double total = 0,;
                foreach (Shape s in lijst)
                {
                    total += s.Opp();
                }


                return total;
            }
            public string Output()
            {
                return "<h1> Totale som = " + Sum() + " </h1> ";
            }
        }

    }
}
