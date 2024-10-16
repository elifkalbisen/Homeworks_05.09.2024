// 3. Encapsulation (Kapsülleme) Nedir?
// Kapsülleme, veri ve metotların bir sınıf içerisinde gizlenmesini sağlar. Böylece, sınıfın iç detayları dışarıdan müdahale edilemez ve yalnızca belirli metotlar aracılığıyla erişilebilir. Bu, veri bütünlüğünü korumak ve hata yönetimini kolaylaştırmak açısından önemlidir.

// Örnek:

public class Kisi
{
    private string isim;
    private int yas;

    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }

    public int Yas
    {
        get { return yas; }
        set
        {
            if (value > 0) yas = value;
        }
    }
}
