using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeOef
{
    class Oef7
    {
        public class Lamp
        {
            Schakelaar schakelaar;
            public Lamp(Schakelaar s)
            {
                this.schakelaar = s;
            }
            public void Aan()
            {
                schakelaar.Aan = true;
                Console.WriteLine("Licht aan");
            }
            public void Uit()
            {
                schakelaar.Aan = false;
                Console.WriteLine("Licht uit");
            }

        }

        public class Schakelaar
        {
            public bool Aan { get; set; }
            public Schakelaar()
            {
                Aan = false;
            }

        }

    }
}
