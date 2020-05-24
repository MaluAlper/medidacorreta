using System;

namespace medidacorreta
{
    class Program
    {
        static void Main(string[] args)
        {
           {
        string metro;
        double metros;
        double cm;
        double km;

        Console.Write("Digite o Valor em Metros ");
        metro = Console.ReadLine();
        metros = double.Parse(metro);
        cm = metros * 100;
        km = metros / 1000;
        Console.WriteLine("o valor de cm é " + cm + "cm");
        Console.WriteLine("o valor de km é " + km + "km");

            
    }
}
}
    }

