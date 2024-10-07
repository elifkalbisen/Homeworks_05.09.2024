namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[10];
        int negatifSayiAdeti = 0;
        int pozitifSayiAdeti = 0; 
        Random random = new Random();

        
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = random.Next(-100, 101);
        }

        
        
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] < 0)
                negatifSayiAdeti++;
            else if (sayilar[i] >= 0)
                pozitifSayiAdeti++;
        }

        int[] pozitifSayilar = new int[pozitifSayiAdeti]; 
        int[] negatifSayilar = new int[negatifSayiAdeti];

        
        negatifSayiAdeti = 0;
        pozitifSayiAdeti = 0;

        
        int j = 0;
        while (j < sayilar.Length)
        {
            if (sayilar[j] < 0)
            {
                negatifSayilar[negatifSayiAdeti] = sayilar[j];
                negatifSayiAdeti++;
            }
            else
            {
                pozitifSayilar[pozitifSayiAdeti] = sayilar[j];
                pozitifSayiAdeti++;
            }
            j++;
        }

       

        Console.Write("Tüm Sayılar: ");
        Console.WriteLine(string.Join(", ", sayilar));

        Console.Write("Negatif Sayılar: ");
        Console.WriteLine(string.Join(", ", negatifSayilar));

        Console.Write("Pozitif Sayılar: ");
        Console.WriteLine(string.Join(", ", pozitifSayilar)); 


    }
}
