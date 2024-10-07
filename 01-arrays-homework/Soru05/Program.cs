namespace Soru05;

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
        Console.WriteLine("Dizideki sayılar:");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        Console.Write("Kontrol edilecek sayıyı girin: ");
        int arananSayi = Convert.ToInt32(Console.ReadLine());

        bool bulundu = false;
        int tekrarSayisi = 0;
        string pozisyonlar = "";

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] == arananSayi)
            {
                if (!bulundu) bulundu = true;
                pozisyonlar += i + " ";
                tekrarSayisi++;
            }
        }

        if (bulundu)
        {
            Console.WriteLine($"Sayı {arananSayi} dizide mevcut.");
            Console.WriteLine($"Pozisyonlar: {pozisyonlar}");
            Console.WriteLine($"Tekrar Sayısı: {tekrarSayisi}");
        }
        else
        {
            Console.WriteLine($"Sayı {arananSayi} dizide bulunamadı.");
        }
    }
}
