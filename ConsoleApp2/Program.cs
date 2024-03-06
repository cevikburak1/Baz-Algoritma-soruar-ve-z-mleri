using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;

internal class Program
{
    //public BigInteger Sum(string val1,string val2)
    //{
    //    var result1 = BigInteger.Parse(val1);
    //    var result2 = BigInteger.Parse(val2);
    //    BigInteger conclusion = (result1 + result2);
    //    return conclusion;
    //}

    public static void Main(string[] args)
    {
        Program program = new Program();
        string result = program.Result();
        Console.WriteLine(result);
    }

    //public int Sum()
    //{
    //    var sum =0;
    //   for (int i = 0; i <= 10; i++)
    //    {
    //        var result = i*i*i;
    //        sum +=result;
    //    }
    //   return sum;
    //}

    //public int Yaş()
    //{
    //    Console.WriteLine("Dogum Tarihi Giriniz");
    //    DateTime dogrumTarihi = Convert.ToDateTime(Console.ReadLine());
    //    var nowTime = DateTime.Now.Year;
    //    var result= (nowTime -dogrumTarihi.Year);
    //    return result;
    //}

    //public int Faktoriyel()
    //{
    //    Console.WriteLine("SAYI GİRİN : ");
    //    int sayi = Convert.ToInt16(Console.ReadLine());
    //    var sonuc =1;
    //    for (int i = sayi; sayi>= 1; sayi--)
    //    {
    //        sonuc *= sayi; 
    //    }
    //    return sonuc;
    //}


    //public int ÇarpmayıToplamaOlarakYapmak()
    //{
    //    Console.WriteLine("SAYI GİRİN : ");
    //    int sayi1 = Convert.ToInt16(Console.ReadLine()); //4
    //    Console.WriteLine("SAYI GİRİN : ");
    //    int sayi2 = Convert.ToInt16(Console.ReadLine()); //2
    //    var sonuc = 0;
    //    for (int i = 1; i <= sayi2; i++)
    //    {
    //        sonuc += sayi1;
    //    }
    //    return sonuc;

    //}


    //public int GirilenSayınnKaçBasamaklıOldugunuBulma()
    //{
    //    Console.WriteLine("SAYI GİRİN : ");
    //    int sayi = Convert.ToInt16(Console.ReadLine());
    //    int sayac = 1;
    //    for (int i = sayi; sayi > 10;)
    //    {
    //        sayi = sayi / 10;
    //        sayac++;
    //    }
    //    return sayac;

    //}


    //10 ile 1000 arasındaki tam kare sayıları ekrana yazdıran program
    //public List<int> onile1000arasındakitamkaresayılarıekranayazdıranprogram()
    //{
    //    int sayi = 4;
    //    List<int> sonuc = new List<int> { };
    //    for (int i = sayi; (sayi * sayi) <= 1000; sayi++)
    //    {
    //        sonuc.Add(sayi * sayi);
    //    }
    //    return sonuc;

    //}


    //Klavyeden girilen 5 adet sayı içerisinden negatif olanların toplamını,  çift sayıların çarpımını, 7'ye eşit olanların adetini bulup ekranayazdıran program

    //public int Result()
    //{
    //    int sayi = 1;
    //    int negatiflerintoplamı = 0;
    //    int çiftsayılarınçarpmı = 1;
    //    int yediyeeşitolanlarınsayisi = 0;
    //    int sonuc = 0;
    //    for (int i = sayi; i<= 5; i++)
    //    {
    //         Console.WriteLine($"{i}.SAYIYI GİRİN : ");
    //         int giriilendeger = Convert.ToInt16(Console.ReadLine());
    //        if (giriilendeger < 0)
    //        {
    //            negatiflerintoplamı+=giriilendeger;

    //        }
    //        if(giriilendeger>0 && giriilendeger%2==0 && giriilendeger!=7)
    //        {
    //            çiftsayılarınçarpmı *= giriilendeger; 
    //        }
    //        if (giriilendeger == 7)
    //        {
    //            yediyeeşitolanlarınsayisi++;
    //        }
    //         sonuc = çiftsayılarınçarpmı;
    //    }
    //    return sonuc;

    //}


    //X,Y pozitif olmak üzere, eğer x sayısının çarpanları toplamı y sayısına
    //ve aynı zamanda y sayısının çarpanları toplamı x sayısına eşit ise bu
    //sayılar dost sayılardır.Buna göre girilen iki sayının dost olup
    //olmadığını bulan program

    //public string Result()
    //{
    //    Console.WriteLine(" X  SAYIYI GİRİN : ");
    //    int x = Convert.ToInt16(Console.ReadLine());

    //    Console.WriteLine("Y  SAYIYI GİRİN : ");
    //    int y = Convert.ToInt16(Console.ReadLine());

    //    int xSaysınınÇarpalnlarıToplamı = 0;
    //    int ySaysınınÇarpalnlarıToplamı = 0;
    //    string sonuc = "";
    //    for (int i = 1; i <= x; i++)
    //    {
    //        if (x % i == 0)
    //        {
    //            xSaysınınÇarpalnlarıToplamı += i; 
    //        }
    //    }
    //    for (int i = 1; i <= y; i++)
    //    {
    //        if (y % i == 0)
    //        {
    //            ySaysınınÇarpalnlarıToplamı += i;
    //        }
    //    }
    //    if (xSaysınınÇarpalnlarıToplamı == ySaysınınÇarpalnlarıToplamı)
    //    {
    //        sonuc = "X ve Y sayıları Dost Sayılardır";
    //    }
    //    else
    //    {
    //        sonuc = "X ve Y sayıları Dost Sayı Degillerdir";
    //    }
    //    return sonuc;

    //}


    //Girilen sayının mükemmel sayı olup olmadığını bulan program
    //public string Result()
    //{
    //    Console.WriteLine(" X  SAYIYI GİRİN : ");
    //    int sayi = Convert.ToInt16(Console.ReadLine());
    //    string sonuc = "Mükemmel Sayı Degildir";
    //   int toplam = 0;
    //    for (int i = 1; i <sayi; i++)
    //    {
    //        if (sayi % i == 0)
    //        {
    //            toplam += i;
    //        }
    //    }
    //    if (toplam == sayi)
    //    {
    //        return sonuc = "Mükmmel Sayıdır";
    //    }
    //    return sonuc;

    //}


    //1-100 arasındaki çift sayıların toplamının mükemmel sayı olup
    //olmadığını bulan program

    //public string Result()
    //{
    //    string sonuc = "Mükemmel Sayı Degildir";
    //    int toplam = 0;
    //    int mükemmeltoplam = 0;
    //    for (int i = 2; i < 100; i+=2)
    //    {
    //        toplam += i;
    //    }
    //    for (int i = 1; i < toplam; i++)
    //    {
    //        if (toplam % i == 0)
    //        {
    //            mükemmeltoplam += i;
    //        }
    //    }
    //    if (mükemmeltoplam == toplam)
    //    {
    //        return sonuc = "Mükmmel Sayıdır";
    //    }
    //    return sonuc;

    //}


    //Herhangi bir sayının herhangi bir dereceden kuvvetini bulan
    //program

    //public int Result()
    //{
    //  int sonuc = 1;
    //    Console.WriteLine(" X  SAYIYI GİRİN : ");
    //    int x = Convert.ToInt16(Console.ReadLine()); //4

    //    Console.WriteLine("Y  SAYIYI GİRİN : ");
    //    int y = Convert.ToInt16(Console.ReadLine());//2

    //    for (int i =1; i <= y; i++)
    //    {
    //        sonuc *= x;
    //    }
    //    return sonuc;
    //}


    //Girilen a ve b sayısı 50'den büyük olduğunda c=a+b işlemini yapan
    //değilse bu sayılar uygun değil yazdıran program

    //public string Result()
    //{
    //    int c = 0;
    //    Console.WriteLine(" A  SAYIYI GİRİN : ");
    //    int A = Convert.ToInt16(Console.ReadLine()); //4

    //    Console.WriteLine("B  SAYIYI GİRİN : ");
    //    int B = Convert.ToInt16(Console.ReadLine());//2

    //    if(A>50 && B > 50)
    //    {
    //        c=A+B;
    //    }
    //    else
    //    {
    //        return "Sayılar Uygun Degil";
    //    }

    //    return c.ToString();
    //}


    //Boyu ile kilosu girilen kişinin şişman mı, zayıf mı yoksa ideal kiloda mı
    //olduğunu gösteren program
    //public string Result()
    //{

    //    Console.WriteLine(" Boyunuzu  GİRİN : ");
    //    int boy = Convert.ToInt16(Console.ReadLine());

    //    Console.WriteLine(" Kilonuzu GİRİN : ");
    //    int kilo = Convert.ToInt16(Console.ReadLine());

    //    int sonuc = (boy - 100 - kilo);
    //    if (sonuc > 11)
    //    {
    //        var kaçkiloalmalı = sonuc - 11;
    //        return kaçkiloalmalı + "" + "Kilo Almalısınız";
    //    }
    //    else if (sonuc == 11)
    //    {
    //        return "İdeal Kilodasınız";
    //    }
    //    else
    //    {
    //        var kaçkiloalmalı = 11 + (sonuc);
    //        return kaçkiloalmalı + "" + "Kilo Vermelisiniz";
    //    }
    //}



    //4 haneli bir sayının birler, onlar, yüzler ve binler hanesini bulan program

    //public string Result()
    //{

    //    Console.WriteLine(" sayi  GİRİN : ");
    //    int sayi = Convert.ToInt16(Console.ReadLine());

    //    int binlerbasamagi = sayi / 1000;
    //    int yüzlerbasamagi = (sayi / 100) % 10;
    //    int onlarbasamagi = (sayi / 10) % 10;
    //    int birlerbasamagi = sayi % 10;

    //    return "Basamak Degerleri : " + "Binler Basamagı : "+" " + binlerbasamagi + "yüzler Basamagı : " +" "+ yüzlerbasamagi +" "+ "onlar Basamagı : " +" "+ onlarbasamagi+"" + "Birler Basamagı : "+" " + birlerbasamagi;


    //}


    //Rastgele girilen 5 sayıdan negatif olanların ve pozitif olanların
    //sayısını bulan program

    //public string Result()
    //{
    //    List<int> pozitiflerinsayisi = new List<int>();
    //    List<int> neagitflerinsayisi = new List<int>();
    //    for (int i = 1; i <= 5; i++)
    //    {
    //        Console.WriteLine($"{i}. sayiyi  GİRİN : ");
    //        int sayi = Convert.ToInt16(Console.ReadLine());
    //        if (sayi > 0)
    //        {
    //            pozitiflerinsayisi.Add(sayi);
    //        }
    //        else
    //        {
    //            neagitflerinsayisi.Add(sayi);
    //        }
    //    }
    //    return "Pozitiflerin Sayısı : " + " " + pozitiflerinsayisi.Count + " " + "Negatiflerin  Sayısı  : " + " " + neagitflerinsayisi.Count;

    //}


    //Sayı bulmaca oyunu programı
    //public string Result()
    //{
    //    Random random = new Random();
    //    int tutulansayi = random.Next(0, 10);
    //    string mesaj = "";
    //    for (int i = 1; i <= 10; i++)
    //    {

    //        Console.WriteLine($"{i}.Hakkınız: ");
    //        int girilensayi = Convert.ToInt16(Console.ReadLine());
    //        if (girilensayi == tutulansayi)
    //        {
    //          return  mesaj =  $"{i}.Hakkınızda Buldunuz Tebrikler";
    //        }
    //        else if (girilensayi > tutulansayi)
    //        {
    //            mesaj = "tahmini azalt";
    //            Console.WriteLine(mesaj);
    //        }
    //        else
    //        {
    //            mesaj = "tahmini arttır";
    //            Console.WriteLine(mesaj);
    //        }
    //    }

    //    return mesaj;

    //}


    //Girilen sayının Karekökümü bulan program ???
    //public  string Result()
    //{
    //    Console.WriteLine(" X  SAYIYI GİRİN : ");
    //    int girilensayi = Convert.ToInt16(Console.ReadLine());
    //    double sonuc = 0;
    //    for (int i = 1; i <= girilensayi/2; i++)
    //    {
    //        if (i * i == girilensayi)
    //        {
    //            sonuc = i;
    //            break;
    //        }
    //    }
    //    return sonuc.ToString();

    //}



    //Obeb-Okek bulma
    //public string Result()
    //{
    //    Console.WriteLine(" X  SAYIYI GİRİN : ");
    //    int x = Convert.ToInt16(Console.ReadLine());

    //    Console.WriteLine(" Y  SAYIYI GİRİN : ");
    //    int y = Convert.ToInt16(Console.ReadLine());

    //    int küçükdeger = 0;

    //    int obeb = 0;
    //    int okek = 0;
    //    if (x > y)
    //    {
    //        küçükdeger = y;
    //    }
    //    else
    //    {
    //        küçükdeger = x;
    //    }
    //    for (int i = 1; i <= küçükdeger; i++)
    //    {
    //        List<int> list = new List<int>();

    //        if (x%i==0 && y%i==0)
    //        {
    //            list.Add(i);
    //            obeb = list.Max();
    //        }
    //    }
    //    //Okek
    //    if (x > y)
    //    {
    //        if (x / y == 0)
    //        {
    //            okek = x;
    //        }
    //        else
    //        {
    //            okek = (x * y)/obeb;
    //        }
    //    }
    //    if (y > x)
    //    {
    //        if (y / x == 0)
    //        {
    //            okek = y;
    //        }
    //        else
    //        {
    //            okek = (x * y) / obeb;
    //        }
    //    }

    //    return $"Obeb Degeri :{obeb.ToString()}  Okek Degeri : {okek.ToString()}";

    //}


    //1 ile 5 arasındaki tam sayıların karelerinin çarpımını bulan program
    //public string Result()
    //{
    //    double sonuc = 1;
    //    for (int i = 1; i <= 5; i++)
    //    {
    //        sonuc *=i*i;
    //    }
    //    return sonuc.ToString();

    //}



    //10-100 Arasındaki Asal Sayıları yazdırma
    //public string Result()
    //{
    //    List<int> asalsayılar = new List<int>();
    //    for (int i = 10; i <= 100; i++)
    //    {
    //        if(i%2!=0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
    //        {
    //            Console.WriteLine(i);
    //            asalsayılar.Add(i);
    //        }
    //    }

    //    return "";

    //}


    //Girilen syının basamak degeri ve kaç basamklı oldugnu bulan program
    //public string Result()
    //{
    //    Console.WriteLine("Bir sayı girin:");
    //    int sayi = Convert.ToInt32(Console.ReadLine());
    //    int basamakSayisi = 0;
    //    int basamakdegertoplamı = 0;
    //    for (int i = sayi; i != 0; i /= 10)
    //    {
    //        basamakSayisi++;
    //    }

    //    Console.WriteLine("Girdiğiniz sayı " + basamakSayisi + " basamaklıdır.");

    //    for (int i = 0; i < basamakSayisi; i++)
    //    {
    //        int basamakDegeri = sayi % 10;
    //        Console.WriteLine("Basamak: " + basamakDegeri);

    //        basamakdegertoplamı +=basamakDegeri;

    //        sayi /= 10;
    //    }
    //    Console.WriteLine("basamakdegertoplamı: " + basamakdegertoplamı);
    //    return "";

    //}


    //Girilen Sayının En Büyük sayısını bulma
    //public string Result()
    //{
    //    List<int> enbüyükbasamaksayısı = new List<int>();
    //    Console.WriteLine("Bir sayı girin:");
    //    int sayi = Convert.ToInt32(Console.ReadLine());
    //    int basamakSayisi = 0;
    //    int basamakdegerleri;
    //    for (int i = sayi; i!=0; i/=10)
    //    {
    //        basamakSayisi++;
    //    }
    //    for (int i = 0; i < basamakSayisi; i++)
    //    {
    //        basamakdegerleri = sayi % 10;
    //        enbüyükbasamaksayısı.Add(basamakdegerleri);
    //    }

    //    Console.WriteLine(" en büyük sayı: " + enbüyükbasamaksayısı.Max());
    //    return "";

    //}



    //Ekrandan girilen bir sayı eğer 5-10 arasında ise girilen sayının karesini alıp gösteren, eğer 5'ten küçük ise faktöriyelini alan, 10'dan büyük ise sayıyı ikiye bölüp bir eksiğini yazan program
    //public string Result()
    //{

    //    Console.WriteLine("Bir sayı girin:");
    //    int sayi = Convert.ToInt32(Console.ReadLine());
    //    int sonuc = 1;
    //    if(sayi>=5 && sayi <= 10)
    //    {
    //        sonuc = sayi * sayi;
    //    }
    //    if (sayi < 5)
    //    {
    //        for (int i = 1; i <= sayi; i++)
    //        {
    //            sonuc *= i;
    //        }
    //    }
    //    if (sayi > 10)
    //    {
    //        sonuc = (sayi/2)-1;
    //    }

    //    Console.WriteLine(" Sonuç:  " + sonuc);
    //    return "";

    //}



    //Bölme İşlemini Bölme kullanmadan Yapmak

    //public string Result()
    //{

    //    Console.WriteLine("x sayı girin:");
    //    int x = Convert.ToInt32(Console.ReadLine());//24
    //    Console.WriteLine("y sayı girin:");
    //    int y = Convert.ToInt32(Console.ReadLine());//4
    //    int sonuc = 0;
    //    for (int i = x;i>=y; i-=y)
    //    {
    //        sonuc++;
    //    }


    //    Console.WriteLine(" Sonuç:  " + sonuc);
    //    return "";

    //}


    //Arka arkaya girilen rastgele 10 tam sayının ortalaması ile bu
    //sayılardan en büyük ve en küçük olanın ortalamasını bularak elde
    //edilen bu iki ortalamanın farkını bulan program

    //public string Result()
    //{
    //    List<int>list = new List<int>();
    //    int toplam = 0;
    //    int ortalama = 0;
    //    for (int i = 1; i <= 10; i++)
    //    {
    //        Console.WriteLine($"{i}.Sayıyı girin:");
    //        int x = Convert.ToInt32(Console.ReadLine());
    //        list.Add(x);
    //        toplam += x;

    //    }
    //    ortalama = toplam / 10;
    //    int enbüyük = list.Max();
    //    int enküçük = list.Min();
    //    int enbüyükenküçükortalaması = (enbüyük + enküçük) / 2;

    //    if (ortalama > enbüyükenküçükortalaması)
    //    {
    //        Console.WriteLine(" Sonuç:  " + (ortalama - enbüyükenküçükortalaması));
    //    }
    //    else
    //    {
    //        Console.WriteLine(" Sonuç:  " + (enbüyükenküçükortalaması - ortalama));
    //    }
    //    return "";

    //}




    //k sayısı tek ise 3 ile çarpılıp 1 ekleniyor çift ise 2 ile bölünüyor işlem
    //k sayısı 1 olana kadar devam ediyor bu işlemin kaç adım
    //sürdüğünü,işlem sırasında k sayısının aldığı max değeri k sayısının
    //hangi sayıdan sonra hep çift olarak 1'e ulaştığını bulan program

    //public string Result()
    //{

    //    Console.WriteLine("Sayıyı girin:");
    //  int k = Convert.ToInt32(Console.ReadLine());
    //    List<int> list = new List<int>();
    //    int sayac = 0;
    //    for (int i = k; k >1;)
    //    {
    //        list.Add(k);
    //        sayac++;
    //        if (k % 2 == 0)
    //        {
    //            k /= 2;
    //        }
    //        else if (k%+2 != 0)
    //        {              
    //            k = (k * 3) + 1;
    //        }
    //    }


    //  Console.WriteLine(" Kaç Adım Sürdü:  " + sayac  + " K' Nın aladıgı Max deger :  " + list.Max() + " K' Nın aladıgı Min deger :  " + list.Min());
    //  return "";
    //}



    //Bir sayı dizisinin en büyük elemanını bulan program
    //public string Result()
    //{

    //    int[] sayiDizisi = new int[] { 1, 2, 3, 4, 5 };

    //    Console.WriteLine("K' Nın aladıgı Max deger :  " + sayiDizisi.Max());
    //    return "";

    //}



    //Girilen kelimeyi tersten yazdıran program

    //public string Result()
    //{
    // Console.WriteLine("Kelime girin:");
    // string k = Console.ReadLine();
    // char[] dizi = k.ToCharArray(); // string dizisini chara dönüştürdüm 
    // Array.Reverse(dizi);// Diziyi tersine çevirdim
    // string tersstring = new string(dizi); //Burda da diziyi stringe  dönüştrdüm
    // Console.WriteLine("K' Nın aladıgı  deger :  " + tersstring);
    // return "";

    //}


    //10 elemanlı bir sayı dizisinde en küçük elemanın bu dizinin kaçıncı 
    //elemanı olduğunu bulan program

    //public string Result()
    //{
    //    int[] sayiDizisi = { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 };
    //    int min = sayiDizisi.Min();
    //    int minIdenx = Array.IndexOf(sayiDizisi, min);//En Küçük Elemanın Dizideki Sırasını Buluyor
    //    Console.WriteLine("K' Nın aladıgı  deger :  "  + minIdenx);
    //    return "";

    //}



    //Girilen Kelimenin Polindrom Olup Olmadını Bulan Program

    //public string Result()
    //{
    //    Console.WriteLine("Kelime girin:");
    //    string k = Console.ReadLine();
    //    char[] dizi = k.ToCharArray();
    //    Array.Reverse(dizi);
    //    string terstenokunuşu = new string(dizi);
    //    if (k == terstenokunuşu)
    //    {
    //        Console.WriteLine("Polindromdur");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Polindrom Degildir");
    //    }
    //    return "";

    //}

    //BİLGİSAYAR  kelimesinin harflerini birer sola kaydırarak yeniden bilgisayar olunca bulan Program
    //public string Result()
    //{
    //    string kelime = "Bilgisayar";
    //    char[] dizi = kelime.ToCharArray();
    //    bool kelimeDogru = false;
    //    while (!kelimeDogru)
    //    {
    //        Console.WriteLine(dizi);
    //        char ilkKarakter = dizi[0];
    //        for (int i = 0; i < dizi.Length - 1; i++)
    //        {
    //            dizi[i] = dizi[i + 1];
    //        }
    //        dizi[dizi.Length - 1] = ilkKarakter;
    //        Thread.Sleep(200);
    //        if (new string(dizi) == kelime)
    //        {
    //            Console.WriteLine(kelime);
    //            kelimeDogru = true;
    //        }
    //    }
    //    return "";

    //}



    //Bir sınıftaki 50 öğrencinin bir dersten aldıkları yıl sonu notları
    //veriliyor.Başarı notu 50 olduğuna göre kaç öğrencinin başarılı
    //olduğunu bulan program

    //public string Result()
    //{

    //    int başarılıolanlar = 0;
    //    for (int i = 1; i <= 10; i++)
    //    {
    //        Console.WriteLine($"{i}.Notu girin:");
    //        int girilennot = Convert.ToInt16(Console.ReadLine());
    //        if (girilennot > 50)
    //        {
    //            başarılıolanlar++;
    //        }
    //    }

    //    Console.WriteLine($"Başarılı OLanların Sayısı : {başarılıolanlar}");
    //    return "";

    //}



    //Gelen dizide kaç pozitifi kaç negatif  oldugunu bulma 
    //public string Result()
    //{

    //    int[] sayiDizisi = { 1, -2, 3, -4, 5, 6, 7, -8, 9, -10 };
    //    int negatif = 0;
    //    int pozitif = 0;
    //    for (int i = 0; i < sayiDizisi.Length; i++)
    //    {
    //        int sayi = sayiDizisi[i];
    //        if (sayi > 0)
    //        {
    //            pozitif++;
    //        }
    //        else
    //        {
    //            negatif++;
    //        }
    //    }
    //    Console.WriteLine($"pozitif OLanların Sayısı : {pozitif}");
    //    Console.WriteLine($"negatif OLanların Sayısı : {negatif}");
    //    return "";

    //}


    //11 elemanlı bir dizinin elemanlarından hem 4'e hemde 5'e bölünen
    //sayıları bulan program
    public string Result()
    {
        List<int> list = new List<int>();
        int[] sayiDizisi = { 1, 2, 3, 4, 5, 6, 7, 40, 20, 10,100 };

        for (int i = 0; i < sayiDizisi.Length; i++)
        {
            int sayi =sayiDizisi[i];
            if(sayi%5==0 && sayi % 4 == 0)
            {
                list.Add(sayi);
            }
        }
        foreach (var item in list)
        {
            Console.WriteLine($"4 e ve 5 e  Bölünenler: {item}");
        }
           
        
        return "";

    }

}
