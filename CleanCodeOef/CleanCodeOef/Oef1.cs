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

        // Klasse OPPBerekenaar met meerdere reposibilities
        // out put moet niet in oppervlakte berekenaar zitten


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
                double total = 0;
                foreach (Shape s in lijst)
                {
                    total += s.Opp();
                }
                return total;
            }
            public string Output()
            {
                return Sum().ToString();
            }
        }

        public interface Ilog
        {
            string Output(String message);
        }

        public class HtmlLog : Ilog
        {

            public string Output(string message)
            {
                return "<p>" + message + "</p>";
            }
        }

        public class Log : Ilog
        {
            public string Output(string message)
            {
                return message;
            }
        }

        public void Main()
        {
            OppBerekenaar  ob = new OppBerekenaar();
            ob.VoegToe(new Circle(3));
            ob.VoegToe(new Square(4));
            string html = new HtmlLog().Output("De totale som = "+ ob.Output());
            string log = new Log().Output("De totale som = " + ob.Output());
        }

    }
}
