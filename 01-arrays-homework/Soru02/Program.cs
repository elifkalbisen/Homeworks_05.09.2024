namespace Soru02;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        List<int> ciftListe = new List<int>(); 
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write($"{i+1}. Sayıyı Yazınız: ");
            dizi[i] = int.Parse(Console.ReadLine());
            if (dizi[i] % 2 == 0)
            {
                ciftListe.Add(dizi[i]);                    
            }
           
        }
        ciftListe.Sort();
        int[] cift = ciftListe.ToArray();
        Console.WriteLine("\nDizi: " + string.Join(" ",dizi));
        Console.WriteLine("\nDizi: " + string.Join(" ",cift));
        
    }
}
