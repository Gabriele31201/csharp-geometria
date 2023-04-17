using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class rettangolo
{
    //Attributi
    public int baseRettangolo;
    public int altezzaRettangolo;









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





