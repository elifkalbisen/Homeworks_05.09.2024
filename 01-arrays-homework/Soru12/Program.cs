namespace Soru12;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[100];
        Random random = new Random();
        
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = random.Next(1, 101);
        }

        int enCokTekrarEdenSayi = sayilar[0];
        int maxTekrarSayisi = 0;

        foreach (var sayi in sayilar)
        {
            int tekrarSayisi = 0;

            
            foreach (var kontrolSayi in sayilar)
            {
                if (sayi == kontrolSayi)
                {
                    tekrarSayisi++;
                }
            }

            
            if (tekrarSayisi > maxTekrarSayisi)
            {
                maxTekrarSayisi = tekrarSayisi;
                enCokTekrarEdenSayi = sayi;
            }
        }

        
        Console.WriteLine($"En sık tekrar eden eleman: {enCokTekrarEdenSayi}, Tekrar sayısı: {maxTekrarSayisi}");
    }
}
