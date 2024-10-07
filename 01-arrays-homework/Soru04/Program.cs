namespace Soru04;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[100];
        Random random = new Random();


        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = random.Next(1, 101);
        }

        
        Console.WriteLine("Tekrar eden elemanlar ve pozisyonları:");

        bool[] kontrolEdildi = new bool[sayilar.Length];
        
        
        foreach (var sayi in sayilar)
        {
            int index = Array.IndexOf(sayilar, sayi);
            if (kontrolEdildi[index]) continue;

            bool tekrarVar = false;
            string pozisyonlar = $"{index}";

            for (int j = index + 1; j < sayilar.Length; j++)
            {
                if (sayi == sayilar[j])
                {
                    pozisyonlar += $", {j}";
                    kontrolEdildi[j] = true; 
                    tekrarVar = true;
                }
            }

            if (tekrarVar)
            {
                Console.WriteLine($"Değer: {sayi}, Pozisyonlar: {pozisyonlar}");
            }

            kontrolEdildi[index] = true;
        }
    }
}
