namespace Soru15;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 9, 4, 5, 8, 1, 6, 3, 2, 7, 0 };

        Console.WriteLine("Orijinal Dizi:");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        List<int> tekSayilar = new List<int>();
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] % 2 != 0)
            {
                tekSayilar.Add(sayilar[i]);
            }
        }

        
        tekSayilar.Sort();

        int tekIndex = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] % 2 != 0)
            {
                sayilar[i] = tekSayilar[tekIndex];
                tekIndex++;
            }
        }

        Console.WriteLine("Sıralı Dizi (Sadece Tek Sayılar):");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
    }
}
