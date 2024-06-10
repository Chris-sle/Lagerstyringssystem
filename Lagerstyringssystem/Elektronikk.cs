namespace Lagerstyringssystem
{
    internal class Elektronikk : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public int Garantitid { get; set; } // i måneder

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Elektronikk: {Navn}, Pris: {Pris:C}, Garantitid: {Garantitid} måneder");
        }
    }
}
