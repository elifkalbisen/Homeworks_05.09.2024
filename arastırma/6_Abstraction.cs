// 6. Abstraction (Soyutlama) Nedir?

// Soyutlama, gereksiz detayları gizleyerek kullanıcıya yalnızca ilgili bilgiyi sunar. Sınıfların yalnızca önemli yönlerini öne çıkarır ve karmaşıklığı azaltır. Encapsulation gibi veri gizlemeye odaklanır, ancak soyutlama bir sınıfın temel işlevlerini korur.

// Örnek:

public abstract class Cihaz
{
    public abstract void Calistir();
}

public class Bilgisayar : Cihaz
{
    public override void Calistir()
    {
        Console.WriteLine("Bilgisayar çalışıyor.");
    }
}