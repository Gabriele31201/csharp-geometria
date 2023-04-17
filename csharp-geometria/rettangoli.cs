using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilMioRettangolo
{


    public class Rettangolo
    {
        //Attributi
        public int baseRettangolo;
        public int altezzaRettangolo;

        //Costruttore

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }








        //Metodi

        public int calcoloArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }

        public int calcoloPerimetro()
        {
            int perimetro = baseRettangolo * 2 + altezzaRettangolo * 2;
            return perimetro;
        }
    }

}



