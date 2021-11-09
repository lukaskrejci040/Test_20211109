using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_20211109
{
    class Ucet
    {
        public string jmeno;
        public float zustatek;

        public Ucet(string jmeno, float zustatek)
        {
            this.jmeno = jmeno;
            this.zustatek = zustatek;
        }


        public void Vklad(int mnozstvi)
        {
            if(zustatek + mnozstvi > 200000)
            {
                zustatek = 200000;
            }
            else
            {
                zustatek += mnozstvi;
            }
        }
        public void Vyber(int mnozstvi)
        {
            if(zustatek-mnozstvi < 0)
            {
                zustatek = 0;
            }
            else if ()
            {

            }

            
            else 
            {
                zustatek -= mnozstvi;
            }
        }
        public void Plat(int mnozstvi)
        {
            if (zustatek - mnozstvi < 0)
            {
                zustatek = 0;
            }
            else
            {
                zustatek -= mnozstvi;
            }
        }
    }
}//alespoň za 4 prosím






//float