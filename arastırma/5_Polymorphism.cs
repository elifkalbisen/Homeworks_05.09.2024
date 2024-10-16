// 5. Polymorphism (Çok Biçimlilik) Nedir?
// Polymorphism, nesnelerin farklı şekillerde davranabilmesini sağlar. Bu, metodun adının aynı kalmasına karşın farklı sınıflarda farklı işlevler üstlenebilmesi anlamına gelir. Overloading (aşırı yükleme) ve Overriding (geçersiz kılma) ile gerçekleştirilir.

// Örnek:


public class Sekil
{
    public virtual void Ciz()
    {
        Console.WriteLine("Bir şekil çiziliyor.");
    }
}

public class Daire : Sekil
{
    public override void Ciz()
    {
        Console.WriteLine("Bir daire çiziliyor.");
    }
}