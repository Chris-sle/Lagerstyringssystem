using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Klær : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Størrelse { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Klær: {Navn}, Pris: {Pris:C}, Størrelse: {Størrelse}");
        }
    }
}
