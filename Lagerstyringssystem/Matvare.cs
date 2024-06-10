namespace Lagerstyringssystem
{
    internal class Matvare : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public DateTime Utløpsdato { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Matvare: {Navn}, Pris: {Pris:C}, Utløpsdato: {Utløpsdato.ToShortDateString()}");
        }
    }
}
