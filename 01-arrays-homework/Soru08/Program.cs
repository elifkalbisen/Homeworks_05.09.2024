namespace Soru08;

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

        Console.WriteLine("Dizideki sayılar:");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        Console.Write("Bir sayı girin: ");
        int arananSayi = Convert.ToInt32(Console.ReadLine());

        bool bulundu = false;
        foreach (var sayi in sayilar)
        {
            if (sayi == arananSayi)
            {
                bulundu = true; 
                break;
            }
        }

        if (!bulundu)
        {
            
            Array.Sort(sayilar);

            
            int[] yeniDizi = new int[sayilar.Length + 1];
            int index = 0;

           
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (arananSayi < sayilar[i] && index == i)
                {
                    yeniDizi[index++] = arananSayi;
                }
                yeniDizi[index++] = sayilar[i];
            }

            
            if (index == sayilar.Length)
            {
                yeniDizi[index] = arananSayi;
            }

            Console.WriteLine("Yeni dizi:");
            foreach (var sayi in yeniDizi)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Girilen sayı dizide mevcut.");
        }
    }
}
