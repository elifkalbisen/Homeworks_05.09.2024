namespace Soru06;

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

        Console.WriteLine("Dizideki sayılar:");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        int enBuyuk = sayilar[0];
        int enKucuk = sayilar[0];

        foreach (int sayi in sayilar)
        {
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }
            if (sayi < enKucuk)
            {
                enKucuk = sayi;
            }
        }

        Console.WriteLine("En büyük sayı: " + enBuyuk);
        Console.WriteLine("En küçük sayı: " + enKucuk);
    }
}
