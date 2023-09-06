using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedelja9_2021_1.BusinessLogic
{
    public class Klasa
    {
        private Klasa()
        {

        }
        private static Klasa objekat;
        public static Klasa Singleton
        {
            get
            {
                if (objekat == null)
                {
                    objekat = new Klasa();
                }
                return objekat;
            }
        }
    }

    public class Main 
    {
        public void MainMethod()
        {
            var instanca = Klasa.Singleton;
            var instanca2 = Klasa.Singleton;
        }
    }
}
