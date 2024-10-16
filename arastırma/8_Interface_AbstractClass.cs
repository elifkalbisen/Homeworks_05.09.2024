// 8. Interface ve Abstract Class Nedir?
// Interface, yalnızca metot imzalarını tanımlar, bu metotların içeriği alt sınıflarda tanımlanır. Abstract class ise, hem metot imzalarını hem de bazı metotların içeriğini içerebilir.
// Örnek:

public interface IYuruyen
{
    void Yuru();
}

public abstract class Kus
{
    public abstract void Uc();
}

public class Serce : Kus, IYuruyen
{
    public override void Uc()
    {
        Console.WriteLine("Serçe uçuyor.");
    }

    public void Yuru()
    {
        Console.WriteLine("Serçe yürüyor.");
    }
}