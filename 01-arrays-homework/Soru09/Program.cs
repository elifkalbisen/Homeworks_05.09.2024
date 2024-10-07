namespace Soru09;

class Program
{
    static void Main(string[] args)
    {
       int[] sayilar = { -5, 10, 3, -1, 8, 98, -7, 2, 1, -6 };
        
        List<int> pozitifSayilar = new List<int>();
        
        foreach (var sayi in sayilar)
        {
            if (sayi > 0)
            {
                pozitifSayilar.Add(sayi);
            }
        }

        
        pozitifSayilar.Reverse();

       
        int pozitifIndex = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] > 0)
            {
                sayilar[i] = pozitifSayilar[pozitifIndex++];
            }
        }

        
        Console.WriteLine("Ters çevrilmiş dizinin pozitif elemanları:");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
    }
}
