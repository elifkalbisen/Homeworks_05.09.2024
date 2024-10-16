// 7. Constructor (Yapıcı Metot) Nedir?
// Yapıcı metotlar, bir nesne oluşturulurken ilk değerlerin atanmasını sağlar. Her sınıfın bir yapıcı metodu olabilir ve parametre alabilir.
// Örnek:

public class Kisi
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public Kisi(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }
}