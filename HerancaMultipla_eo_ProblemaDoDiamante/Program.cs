using HerancaMultipla_eo_ProblemaDoDiamante.Devices;
using System;

namespace HerancaMultipla_eo_ProblemaDoDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer P = new Printer() { SerialNumber = 1080 };

            P.ProcessDoc("My letter");
            P.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());
            Console.WriteLine();

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };

            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
