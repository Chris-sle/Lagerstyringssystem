using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Lager
    {
        private List<IProdukt> produkter = new List<IProdukt>();

        public void LeggTilProdukt(IProdukt produkt)
        {
            produkter.Add(produkt);
            Console.WriteLine($"{produkt.Navn} er lagt til i lageret");
        }

        public void FjernProdukt(string navn)
        {
            var produkt = produkter.FirstOrDefault(p => p.Navn == navn);
            if (produkt != null)
            {
                produkter.Remove(produkt);
                Console.WriteLine($"{produkt.Navn} er fjernet fra lageret");
            }
            else
            {
                Console.WriteLine($"Fant ikke produkt med navn {navn} i lageret");
            }
        }

        public void ListOppProdukter()
        {
            if (produkter.Count == 0)
            {
                Console.WriteLine("Lageret er tomt.");
            }
            else
            {
                Console.WriteLine("Produkter i lageret");
                foreach (var produkt in produkter)
                {
                    produkt.SkrivUtInfo();
                }
            }
        }
    }
}
