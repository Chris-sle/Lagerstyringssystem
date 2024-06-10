namespace Lagerstyringssystem;

public interface IProdukt
{
    string Navn { get; set; }
    double Pris { get; set; }

    void SkrivUtInfo();
}