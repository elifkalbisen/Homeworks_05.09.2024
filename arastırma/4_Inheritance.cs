// 4. Inheritance (Kalıtım) Nedir?
// Kalıtım, bir sınıfın özelliklerini ve metotlarını başka bir sınıfa aktarmasını sağlar. Bu özellik, kodun yeniden kullanılabilirliğini artırır. Örneğin, Hayvan sınıfı tüm hayvanların ortak özelliklerini tanımlarken, Kedi sınıfı Hayvan sınıfından türeyebilir ve ek özellikler ekleyebilir.
// Örnek:

public class Hayvan
{
    public void HareketEt()
    {
        Console.WriteLine("Hareket ediyorum.");
    }
}

public class Kedi : Hayvan
{
    public void Miyav()
    {
        Console.WriteLine("Miyav!");
    }
}