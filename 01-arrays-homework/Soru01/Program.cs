namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int [10];
        Random rnd = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rnd.Next(1,101);
        }

        Console.WriteLine("Dizi: " + string.Join(" ",dizi));

        for (int i = 1; i < dizi.Length-1; i++)
        {
            if (dizi[i]>dizi[i-1] && dizi[i]>dizi[i+1])
            {
              Console.WriteLine($"Dizide ki {dizi[i]} elemanı, {dizi[i-1]} ve {dizi[i+1]} elemanlarından büyüktür.");   
            }
        }

       
        
    }
}
