
using ilMioRettangolo;

Console.WriteLine(" CALCOLIAMO L'AREA E IL PERIMETRO DI UN RETTANGOLO");

Console.WriteLine();



Rettangolo datiRettangolo = new Rettangolo (10, 20);

Console.WriteLine("l' area del tuo rettangolo è: " + datiRettangolo.calcoloArea() + "cm2");

Console.WriteLine("il perimetro del tuo rettangolo è: " + datiRettangolo.calcoloPerimetro() + "cm");
