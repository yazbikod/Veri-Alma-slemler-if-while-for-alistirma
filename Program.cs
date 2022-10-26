using System;
using System.Collections;

while (true)
{
    Console.WriteLine("\n*************************************************************** \n Menu");
    Console.WriteLine("Örnek 1 - Kaç denemede toplam olarak 100 e ulaşırız");
    Console.WriteLine("Örnek 2 - Girilen sayılarla işlemler yapalım");
    Console.WriteLine("Örnek 3 - 100e kadar olan çift sayıları yazalım");
    Console.WriteLine("Örnek 4 - A dan Z ye kadar Alfabeyi yazdıralım");
    Console.WriteLine("Örnek 5 - Dizideki string elemanları ile çalışalım");
    Console.WriteLine("Örnek 6 - Dizideki integer elemanları ile çalışalım");
    Console.WriteLine("Örnek 7 - Diziye 4 tane elaman girelim");
    Console.WriteLine("Örnek 8 - Bir sayının üssünü alalım");
    Console.WriteLine("Örnek 9 - Bir sayının faktöriyelini bulalım");
    Console.WriteLine("Örnek 10 - String Metodları ile çalışalım");
    Console.WriteLine("Örnek 11 - ArrayList ile çalışalım");
    Console.WriteLine("Örnek 12 - Hashtable ile çalışalım");
    Console.WriteLine("Örnek 13 - Stack yapısını öğrenelim");
    Console.WriteLine("Örnek 14 - Queue Kuruk yapısı ile çalışalım");
    Console.WriteLine("Örnek 15 - Girilen Cümleyi Split Ederek Qeueu listenin içine atıyoruz");


    Console.Write("Bir Seçim Yapınız : ");
    string deger = Console.ReadLine();
    switch (deger)
    {
        case "1": Yuzekadar(); break;
        case "2": Topla(); break;
        case "3": CiftSayma(); break;
        case "4": HarfYazdir(); break;
        case "5": Dizi(); break;
        case "6": DiziTransfer(); break;
        case "7": DiziVeriGir(); break;
        case "8": UsAlma(); break;
        case "9": Faktor(); break;
        case "10": StrMetod(); break;
        case "11": List(); break;
        case "12": HashTable(); break;
        case "13": Stack(); break;
        case "14": Queue(); break;
        case "15": Split(); break;
    }
}


static void Topla()
{
    int i = 0, toplam = 0, sayi, tektoplam=0;
    while (i < 5)
    {
        Console.Write(i +1+ ". sayıyı girin : ");
        sayi = Convert.ToInt32(Console.ReadLine());

        toplam += sayi;
        i++;
    }
    Console.WriteLine("Toplam Değer = {0}", toplam);

    for (i = 0; i <5; i++)
    {
        if (i % 2 == 1)
        {
            tektoplam += i;
        }
    }
    Console.WriteLine("Tek sayıların Toplamı : " + tektoplam);
}

static void Yuzekadar()
{
   int toplamm = 0, toplamDeneme = 0, sayim;

    while (toplamm < 100)
    {
        Console.Write("Sayı giriniz :");
        sayim = Convert.ToInt32(Console.ReadLine());
        toplamm += sayim;
        toplamDeneme++;
    }
    Console.WriteLine("Toplam : " + toplamm);
    Console.WriteLine("Deneme Sayısı : " + toplamDeneme);
}

static void CiftSayma ()
{
    int i = 0;
    while (i <= 100)
    {
        Console.WriteLine("Çift Sayilar : ");
        if (i % 2 == 0)
        {
            Console.Write(i+",");
        }
        i++;
    }
}

static void HarfYazdir()
{
    char harf = 'a';

    do
    {
        Console.WriteLine(harf);
        harf++;
    }
    while (harf <= 'z');
}

static void Dizi()
{
    string[] isimler = new string[5];
    isimler[0] = "Ali";
    isimler[1] = "Ahmet";
    isimler[2] = "Ceyda";
    isimler[3] = "Aylin";
    isimler[4] = "Deniz";

    Console.WriteLine("Eleman Sayısı: " + isimler.Length);
    Console.WriteLine("4. Elemanı Yazdır: " + isimler[3]);
    Console.WriteLine("Elemanlar arasında Ali var mıdır : " + isimler.Contains("Ali"));     // true false döner, içeriyor mu? //
    Console.WriteLine("Dizinin Elemanları : ");
    foreach (string yaz in isimler)
        Console.Write(yaz+ ",");

    Console.WriteLine("\nDizi elemanları içinde Osman verisinde index numarası nedir : " + Array.IndexOf(isimler, "Osman")); // index ile içini taratırız, veri varsa index
    Console.WriteLine("Dizi elemanları içinde Deniz verisinde index numarası nedir : " + Array.IndexOf(isimler, "Deniz")); // numarasını verir yoksa -1 yazar 

    Array.Reverse(isimler);
    // reverse ile ters çevirdiğimiz elemanları foreach ile yazdıracağız
    Console.WriteLine("reverse ile ters çevirdiğimiz elemanlar : ");
    foreach (string iso in isimler)
        Console.Write("[{0}]", iso);
}

static void DiziTransfer()
{
    int[] sayilar = { 2,11,23,39,45,62,84,31,3,78,59,41,19};
    int[] ilksayilar = new int[5];
    Array.Copy(sayilar, ilksayilar, 5);

    Console.Write("Tüm Elemanlar : ");
    foreach (int yazi in sayilar)
        Console.Write(yazi+ ",");

    Console.Write("\nDizinin İlk 5 Elemanı : ");
    foreach (int ilkler in ilksayilar)
        Console.Write("[{0}]", ilkler);

    Array.Sort(sayilar);
    Console.WriteLine("\nsort ile sıraladığımız sayıları foreach ile yazdırıyoruz");
    foreach (int sirala in sayilar)
        Console.Write(sirala + ",");

    int adet = 0;

    Console.WriteLine("\nDizi Elemanları içinde arama yapalım");
    Console.WriteLine("Arayacağınız sayıyı giriniz : ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayi2 == sayilar[i])
        {
            adet++;
        }
    }
    if (adet == 0)
    {
        Console.WriteLine("Girilen değer dizinde bulunamadı....");
    }
    else
    {
        Console.WriteLine("Girilen değer dizinde {0} adet bulundu.", adet);
    }
}

static void DiziVeriGir()
{
    int deger;
    int[] gelensayi = new int[4];
    for (int i = 0; i < gelensayi.Length; i++)
    {
        Console.WriteLine(i + 1 + ". sayıyı giriniz... : ");
        deger = Convert.ToInt32(Console.ReadLine());
        gelensayi[i] = deger;
    }

    foreach (int x in gelensayi)
        Console.Write(x + ",");
}

static  void UsAlma()
{
    int sayi, us, sonuc = 1;
    Console.WriteLine("Üssü alınacak sayıyı giriniz : ");
    sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Üssünü giriniz : ");
    us = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= us; i++)
    {
        sonuc *= sayi;
    }
    Console.WriteLine(sonuc);
}

static void Faktor()
{
    int sayi, toplam = 1;
    Console.WriteLine("Faktöriyeli alınacak sayıyı giriniz : ");
    sayi = Convert.ToInt32(Console.ReadLine());

    for (int i = sayi; i > 1; i--)
    {
        toplam *= i;
    }
    Console.WriteLine(toplam);
}

static void StrMetod()
{
    string x = "Ahmet Tuna Bakan";
    Console.WriteLine("Verimiz : "+x);

    Console.WriteLine(".Contains : içinde Tuna var mıdır: " + x.Contains("Tuna"));

    Console.WriteLine(".EndsWith : veri *an* ile mi bitiyor: "+x.EndsWith("an"));

    Console.WriteLine(".Starts : Verimiz *Ahmet* ile mi başlıyor: "+x.StartsWith("Ahmet"));

    Console.Write(".Insert : index sırasına göre veri ekliyoruz : " );
    string y = (x.Insert(0, "Uzman ")); // index sırası ve ardından eklenecek degeri giriyoruz
    x = y;
    Console.WriteLine(x);

    Console.WriteLine(".Remove : verimizin 3 ve 4.  harflerini siliyoruz : " + x.Remove(3, 4)); // tek index numarası verirsen sonrasını tamamen silecektir

    Console.WriteLine(".Replace : veride *a* yerine *e* yazıyoruz :" + y.Replace('a', 'e'));

    Console.WriteLine(".Substring : veriden belirli aralık silme : " + x.Substring(6, 5)); // 5. indexten sonrasını alır, ikince parametre adedini belirtir

    Console.WriteLine("ToLower : Küçük Harflerle yaz: "+ y.ToLower());

    Console.WriteLine("Büyük harflerle yaz : "+y.ToUpper());

    Console.WriteLine("Split Metodu ile isim parçalanır ve dizinin içine atılır, sonra da alt alta yazdırılır..."); 

    string[] kelimeler = y.Split(' ');

    foreach (string kelimeAl in kelimeler)
    {
        Console.WriteLine(kelimeAl);
    }

    // .Trim Başındaki ve sonundaki boşlukları silecektir... 
    // .TrimEnd string ifadeye eklenen son kelime arasındaki boşluğu kaldırır... Uzman Ahmet Tuna BakanMutlu
    // .TrimStart bu seferde başındaki ilk kelimenin sonundaki boşluğu silecektir...


    Console.WriteLine("Concat Stringleri toplama işlemini yapar..."); 

    string ad = "Murat";
    string soyad = "Han";
    string sonuc;
    sonuc = string.Concat(ad + soyad);
    Console.WriteLine(sonuc);
}

static void List()
{
    ArrayList listemiz = new ArrayList();
    listemiz.Add(17);               // Listeye eleman ekleme
    listemiz.Add("Merhaba");
    foreach (object list in listemiz)       // alt alta liste elemanlarının yazımı
    {
        Console.WriteLine("listemiz : "+list);
    }

    Console.WriteLine(".Count : Liste elemanlarının sayısı : " + listemiz.Count);   // Liste elemanlarının sayısını öğrenme

    int[] sayilar = { 1, 6, 54, 7, 26, 48, 53, 23, 3, 5, 8 };
    listemiz.AddRange(sayilar);     // listemize sayılar dizisinin elemanlarını ekleme
    foreach (object list in listemiz)       // alt alta liste elemanlarının yazımı
    {
        Console.WriteLine(".AddRange : listemize sayılar dizisinin elemanlarını ekleme : " + list);
    }

    listemiz.Clear();       // listenin tüm elemanlarını siler
    foreach (object list in listemiz)       // alt alta liste elemanlarının yazımı
    {
        Console.WriteLine(".Clear : listenin tüm elemanlarını siler: " + list);
    }


    Console.WriteLine(".Contains : istemiz içinde bu veri var mı: " + listemiz.Contains(17));       // listemiz içinde bu veri var mı içerir mi

    Console.WriteLine(".IndexOf : elemanın index değerini ver yoksa -1 döndür:  " + listemiz.IndexOf(17));        // elemanın index değerini ver yoksa -1 döndür

    listemiz.Remove("Hello");                       // listeden elemanı kaldır
    Console.WriteLine(".Remove : listeden elemanı kaldır Hello : " +listemiz.Count);

    listemiz.Add(564);
    listemiz.Add(232);

    listemiz.RemoveAt(1);                           // index değeri 1 olan elemanı kaldır
    foreach (object list in listemiz)
    {
        Console.WriteLine(".RemoveAt : index değeri 1 olan elemanı kaldır : " + list);
    }
}

static void HashTable()
{
    Hashtable tahta = new Hashtable();
    tahta.Add("İsim", "Ahmet");
    tahta.Add("Şehir", "İstanbul");

    Console.WriteLine("Dizide bu anahtar kelime var mı Ahmet : "+ tahta.ContainsKey("Ahmet"));  // Dizide bu anahtar kelime var mı içerir mi

    Console.WriteLine("Dizide bu değer var mı Ahmet : " +tahta.ContainsValue("Ahmet"));    // Dizide bu değer var mı

    foreach (string table in tahta.Keys)
    {
        Console.WriteLine("Anahtar kelimeler : "+table);
    }

    foreach (string table in tahta.Values)
    {
        Console.WriteLine("Listedeki değerler : " +table);
    }
}

static void Stack()
{
    Stack kitaplar = new Stack();
    kitaplar.Push("Romanın Güncesi");       // Eleman eklemek için Push kullanıyoruz
    kitaplar.Push("Yeşil Orman");
    kitaplar.Push("Bakkal Çırağı");

    Console.WriteLine("Eleman eklemek için Push kullanıyoruz");
    Console.Write("Kitaplar listesi Eleman sayısı : ");
    Console.WriteLine(kitaplar.Count);

    Console.WriteLine(".Pop : Sonuncu elemanı döndürür ve yığından çıkarır.");
    Console.WriteLine(kitaplar.Pop() + " adlı kitap en son okuduğum kitaptır.");
    // Sonuncu elemanı döndürür ve yığından çıkarır.

    Console.WriteLine("Son elemanı sadece yazdır : " + kitaplar.Peek());  // Son elemanı sadece yazdırır

    Console.WriteLine("elemanı içerir mi Bakkal Çırağı : "+kitaplar.Contains("Bakkal Çırağı"));  // elemanı içerir mi
    /*
    while(kitaplar.Count>0)
    {
    Console.WriteLine(kitaplar.Pop());
    }
    */
    foreach (object kitap in kitaplar)
    {
        Console.WriteLine("Kitap listemiz: " + kitap);
    }
}

static void Queue()
{
    Queue musteri = new Queue();
    musteri.Enqueue("Ali KORKMAZ");
    musteri.Enqueue("Ahmet KIRCA");
    musteri.Enqueue("Ayşe GÜLER");
    musteri.Enqueue("Vehbi SÖYLER");

    Console.WriteLine("Dequeue : Kuyruğa giren ilk elemanı işler ve kuyruktan çıkarır... : " + musteri.Dequeue()); // Kuyruğa giren ilk elemanı işler ve kuyruktan çıkarır...

    Console.WriteLine("peek : Kuyruktaki ilk elemanı sadece işler..." + musteri.Peek());  // Kuyruktaki ilk elemanı sadece işler...

    // Yazdırma ,İşlemi

    while (musteri.Count > 0)
    {
        Console.WriteLine(musteri.Dequeue());
    }

    foreach (object ekranayaz in musteri)
    {
        Console.WriteLine("Kuyruğu yazdır : " +ekranayaz);
    }

}

static void Split()
{
    string cumle;
    
    Queue kuyruk = new Queue();
    Console.Write("Bir cümle giriniz:  ");
    cumle = Console.ReadLine();
    
    for (int i = 0; i<cumle.Split(' ').Length; i++)
    {
        kuyruk.Enqueue(cumle.Split(' ')[i]);
    }
    
    foreach (object yazdir in kuyruk)
    {
        Console.WriteLine(yazdir);
    }
}