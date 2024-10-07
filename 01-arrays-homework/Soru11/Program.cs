namespace Soru11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir cümle girin:");
        string cumle = Console.ReadLine();

        string[] kelimeler = cumle.Split(' ');

        int index = kelimeler.Length - 1;

        Console.WriteLine("Kelime dizisi (tersten):");

        while (index >= 0)
        {
            Console.WriteLine(kelimeler[index]);
            index--;
        }
    }
}
