using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.57;
            //Console.WriteLine(number);
            //Console.WriteLine("****Fiyat Listesi****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 25.50;
            //orangePrice = 37.80;
            //strawberryPrice = 77.4;
            //potatoPrice = 22.3;
            //tomatoPrice = 17.90;

            //Console.WriteLine("-- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("-- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("-- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("-- Patetes Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("-- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("---------------------------------------");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.300;
            //orangeGram = 3.400;
            //strawberryGram = 1.700;
            //potatoGram = 5.450;
            //tomatoGram = 3.650;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;



            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar = " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar = " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + strawberryPrice + " - Toplam Tutar = " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + potatoPrice + " - Toplam Tutar = " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + tomatoPrice + " - Toplam Tutar = " + tomatoTotalPrice);


            //double fulltotalprice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Toplam Alışveriş Tutarı: " + fulltotalprice + " TL");

            #endregion

            #region Char Değişkenler

            //char symbol;

            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** ACIKGOZ Hava Yolları Yolcu Bilgisi ****");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumer;

            //Console.WriteLine("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("İl Bilgisi");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik No");
            //passengerIdentityNumer = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumer + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " - " + passengerDistrict + " / " + passengerCity + " " + " Yolcu Yaşı " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 17500;
            //chairPrice = 4850;
            //tvPrice = 27859;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz.");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz.");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz.");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz.");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Toplam Alışveriş Tutar: " + totalPrice + " TL'dir.");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.WriteLine("Lütfen cinsiyet seçiniz: ");

            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion


            Console.Read();


        }
    }
}
