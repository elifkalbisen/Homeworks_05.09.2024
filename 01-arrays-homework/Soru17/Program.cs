namespace Soru17;

class Program
{
    static void Main(string[] args)
    {
         Random random = new Random();
        int[] sayilar = new int[10];

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = random.Next(1, 101);
        }

        Console.WriteLine("Dizideki sayılar: ");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        int enBuyuk = int.MinValue;
        int ikinciEnBuyuk = int.MinValue;

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] > enBuyuk)
            {
                ikinciEnBuyuk = enBuyuk;
                enBuyuk = sayilar[i];
            }
            else if (sayilar[i] > ikinciEnBuyuk && sayilar[i] != enBuyuk)
            {
                ikinciEnBuyuk = sayilar[i];
            }
        }

        if (ikinciEnBuyuk != int.MinValue)
        {
            Console.WriteLine("En büyük sayı: " + enBuyuk);
            Console.WriteLine("İkinci en büyük sayı: " + ikinciEnBuyuk);
        }
        else
        {
            Console.WriteLine("Dizide yeterli sayı yok.");
        }
    }
}
