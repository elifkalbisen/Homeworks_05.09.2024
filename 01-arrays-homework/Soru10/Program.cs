namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi1 = new int[10];
        int[] dizi2 = new int[10];

        Random random = new Random();


        for (int i = 0; i < dizi1.Length; i++)
        {
            dizi1[i] = random.Next(1, 101);
        }


        Console.WriteLine("İlk Dizi:");
        foreach (var sayi in dizi1)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();


        for (int i = 0; i < dizi1.Length; i++)
        {
            dizi2[i] = dizi1[dizi1.Length - 1 - i];
            
        }

        Console.WriteLine("İkinci Dizi (Ters Sıra):");
        foreach (var sayi in dizi2)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
    }
}
