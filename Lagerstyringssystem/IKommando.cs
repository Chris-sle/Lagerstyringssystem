namespace Lagerstyringssystem;

public interface IKommando
{
    void Run();
    char Character { get; }
}