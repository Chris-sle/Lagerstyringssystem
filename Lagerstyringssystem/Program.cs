namespace Lagerstyringssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lager lager = new Lager();

            Elektronikk elektronikk1 = new Elektronikk { Navn = "Laptop", Pris = 9999.99, Garantitid = 24 };
            Elektronikk elektronikk2 = new Elektronikk { Navn = "Smartphone", Pris = 6999.49, Garantitid = 12 };

            Matvare matvare1 = new Matvare { Navn = "Brød", Pris = 29.99, Utløpsdato = DateTime.Now.AddDays(7) };
            Matvare matvare2 = new Matvare { Navn = "Ost", Pris = 79.99, Utløpsdato = DateTime.Now.AddMonths(2) };

            Klær klær1 = new Klær { Navn = "Jakke", Pris = 1499.50, Størrelse = "L" };
            Klær klær2 = new Klær { Navn = "Bukse", Pris = 799.75, Størrelse = "M" };

            lager.LeggTilProdukt(elektronikk1);
            lager.LeggTilProdukt(elektronikk2);
            lager.LeggTilProdukt(matvare1);
            lager.LeggTilProdukt(matvare2);
            lager.LeggTilProdukt(klær1);
            lager.LeggTilProdukt(klær2);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Velkommen til LAGERapp" +
                                  "\n 1 - Sjekk lager" +
                                  "\n 2 - Legg til nytt produkt" +
                                  "\n 3 - Fjern et produkt" +
                                  "\n 4 - Avslutt");
                var userReply = Console.ReadLine();

                switch (userReply)
                {
                    case "1":
                        lager.ListOppProdukter();
                        break;
                    case "2":
                        Console.WriteLine("Hva vil du legge til? 1. Klær, 2. Matvare, 3. Elektronikk");
                        var userChoice = Console.ReadLine();
                        Console.WriteLine("Skriv navn på produkt:");
                        var nyttProduktNavn = Console.ReadLine();
                        Console.WriteLine("Skriv inn en pris:");
                        var nyttProduktPris = Convert.ToDouble(Console.ReadLine());

                        switch (userChoice)
                        {
                            case "1":
                                Console.WriteLine("Skriv in størrelse:");
                                var nyttProduktStørrelse = Console.ReadLine();
                                lager.LeggTilProdukt(new Klær { Navn = nyttProduktNavn, Pris = nyttProduktPris, Størrelse = nyttProduktStørrelse });
                                break;
                            case "2":
                                Console.WriteLine("Skriv inn utløpsdato (dd/mm/yyyy):");
                                var nyttProduktUtløpsdato = DateTime.Parse(Console.ReadLine());
                                lager.LeggTilProdukt(new Matvare { Navn = nyttProduktNavn, Pris = nyttProduktPris, Utløpsdato = nyttProduktUtløpsdato });
                                break;
                            case "3":
                                Console.WriteLine("Skriv inn garantitid (i måneder):");
                                var nyttProduktGarantitid = Convert.ToInt32(Console.ReadLine());
                                lager.LeggTilProdukt(new Elektronikk { Navn = nyttProduktNavn, Pris = nyttProduktPris, Garantitid = nyttProduktGarantitid });
                                break;
                            default:
                                Console.WriteLine("Ugyldig valg, vennligst prøv igjen.");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Skriv navn på produktet som skal fjernes:");
                        var fjernProduktNavn = Console.ReadLine();
                        lager.FjernProdukt(fjernProduktNavn);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ingen godkjent kommando, prøv igjen.");
                        break;
                }

                Console.WriteLine("Trykk en tast for å fortsette...");
                Console.ReadKey();
            }
        }
    }
}
