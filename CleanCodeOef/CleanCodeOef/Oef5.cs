using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeOef
{
    class Oef5
    {

        //public class Bird
        //{
        //    public virtual void SetLocation(double longitude, double latitude)
        //    {
        //    }
        //    public virtual void SetAltitude(double altitude)
        //    {
        //    }
        //    public virtual void Draw()
        //    {
        //    }
        //}



        public abstract class Bird
        {
            public virtual void SetLocation(double longitude, double latitude)
            {
            }

            public virtual void Draw()
            {
            }
        }

        public abstract class FlyingBird : Bird
        {
            public virtual void SetAltitude(double altitude)
            {
            }
        }

        public class Arend : FlyingBird {
        }

        public class Merel : FlyingBird {
        }

        public class Struisvogel : Bird {
        }

    }
}
