namespace Soru16;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[100];
        int sayac = 0;
        int toplam = 0;
        double ortalama;

        do
        {
            Console.Write("Bir sayı girin (durdurmak için 0 girin): ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 0)
                break;
            sayilar[sayac] = sayi;
            toplam += sayi;
            sayac++;
        } while (true);

        if (sayac > 0)
        {
            ortalama = (double)toplam / sayac;
            Console.WriteLine("Girilen sayılar: ");
            for (int i = 0; i < sayac; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Ortalama: " + ortalama);
        }
        else
        {
            Console.WriteLine("Hiçbir sayı girilmedi.");
        }
    }
}
