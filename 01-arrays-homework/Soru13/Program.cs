namespace Soru13;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[10];
        Random random = new Random();

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

        int toplam = 0;

        
        foreach (var sayi in sayilar)
        {
            if (sayi % 2 != 0)
            {
                toplam += sayi;
            }
        }

        if (toplam % 2 == 0)
        {
            Console.WriteLine("Toplam çift sayıdır. Toplam : " + toplam);
        }
        else
        {
            Console.WriteLine("Toplam tek sayıdır. Toplam : " + toplam);
        }
    }
}
