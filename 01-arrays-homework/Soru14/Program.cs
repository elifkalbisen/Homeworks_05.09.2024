namespace Soru14;

class Program
{
    static void Main(string[] args)
    {

        int[] sayilar = new int[20];
        Random random = new Random();

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = random.Next(1, 1000000);
        }

        Console.WriteLine("Dizideki sayılar: ");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write(sayilar[i] + " ");

            if ((i + 1) % 5 == 0)
            {
                Console.WriteLine();
            }
        }

        int toplam = 0; 

        foreach (var sayi in sayilar)
        {
            if (sayi % 3 == 0)
            {
                toplam += sayi; 
            }
        }

        string toplamStr = toplam.ToString();
        string sonuc = "";

        for (int i = 0; i < toplamStr.Length; i++)
        {
            sonuc += toplamStr[i];

            if ((i + 1) % 5 == 0 && (i + 1) != toplamStr.Length)
            {
                sonuc += " ";
            }
        }

        Console.WriteLine("Toplam: " + sonuc);
    }
}
