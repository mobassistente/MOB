using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOB
{
    public class carregar
    {
        // saber que horas são
        public static void perguntarhoras()
        {
            Mob.Fala(DateTime.Now.ToShortTimeString());
        }

        // saber a data
        public static void perguntardata()
        {
            Mob.Fala(DateTime.Now.ToLongDateString());
        }



    }
}
