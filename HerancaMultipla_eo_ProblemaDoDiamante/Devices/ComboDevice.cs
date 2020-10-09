using System;

namespace HerancaMultipla_eo_ProblemaDoDiamante.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
