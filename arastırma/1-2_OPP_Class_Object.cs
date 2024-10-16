// 1. Nesne Yönelimli Programlama (OOP) Nedir?

// OOP, programlamada kodu daha modüler ve yönetilebilir hale getiren bir yaklaşımdır. Veri ve bu veriye erişim yöntemlerini bir araya getirerek nesneler aracılığıyla çalışır. OOP'nin temel amacı, yazılım projelerinde tekrar kullanılabilirlik, esneklik ve sürdürülebilirliği artırmaktır. Fonksiyonel veya prosedürel programlama gibi diğer yaklaşımlardan farkı, gerçek dünyadaki varlıkların özelliklerini ve davranışlarını modellemeye odaklanmasıdır.


//*****************************************************



// 2. Sınıf (Class) ve Nesne (Object) Nedir?

// Sınıf, belirli bir türdeki nesneler için bir şablon ya da blueprint olarak düşünülebilir. Örneğin, Araba sını
// Örnek:

// Sınıf tanımı
public class Araba
{
    
{
   
public string Marka { get; set; }
    
   
public string Model { get; set; }
    
   
public string Renk { get; set; }
}

// Nesne yaratma

Araba benimArabam = new Araba();
benimArabam.Marka = "Toyota";
benimArabam.Model = "Corolla";
benimArabam.Renk = "Mavi";

