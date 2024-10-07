namespace Soru07;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[50];
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

        int toplam = 0;

        foreach (int sayi in sayilar)
        {
            if (sayi % 2 == 0)
            {
                toplam += sayi;
            }
        }


        Console.WriteLine("Dizideki tüm çift sayıların toplamı: " + toplam);
    }
}
