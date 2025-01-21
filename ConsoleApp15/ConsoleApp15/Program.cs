class Program
{
    static void Main()
    {
        //10 adet tam sayı verisi alacak bir dizi tanımlama
        List<int> sayilar = new List<int>();

        //Dizinin elemanlarını bir for döngüsü ile doldurma ve foreach ile ekrana yazdırma
        Console.WriteLine("10 adet tam sayı giriniz:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            int sayi = int.Parse(Console.ReadLine());
            sayilar.Add(sayi);
        }

        Console.WriteLine("\nGirilen sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
        // Kullanıcıdan alınan yeni bir değeri (11. eleman olarak) diziye ekleme
        Console.Write("\nYeni bir sayı giriniz (11. eleman): ");
        int yeniSayi = int.Parse(Console.ReadLine());
        sayilar.Add(yeniSayi);

        // 4. Adım: Diziyi büyükten küçüğe sıralama ve ekrana yazdırma
        sayilar.Sort();
        sayilar.Reverse();

        Console.WriteLine("\nDizi büyükten küçüğe sıralandı:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}