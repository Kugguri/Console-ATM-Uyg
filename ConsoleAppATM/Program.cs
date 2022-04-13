using System;
using System.Threading;

namespace ConsoleAppATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 8000;

            Console.WriteLine("Bakiye = " + bakiye);
            Console.WriteLine("\n-----İŞLEMLER----\n");
            Console.WriteLine("1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Kart İade");

            menu:
            Console.Write("\n İşleminizi Seçiniz : ");

            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Çekilecek Tutarı Giriniz : ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye -= tutar;
                    if (tutar > bakiye)
                    {
                        Console.Write("Bakiyeniz Yetersiz. Başka tutar giriniz : ");
                        tutar = Convert.ToInt32(Console.ReadLine());

                    }

                    Console.WriteLine("Yeni Bakiyeniz = " + bakiye);
                    break;

                case 2:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += tutar;
                    Console.WriteLine("Yeni bakiyeniz = " + bakiye);
                    break;
                case 3:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    break;
                case 4:
                    Console.WriteLine("Kartınızı almayı unutmayınız.!!");
                    Environment.Exit(0);////////
                    break;
                default:
                    Console.WriteLine("Yanlıs islem secitiniz. Tekrar giriniz.");
                    break;
            }
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("Ana Menüye Geçiliyor Lutfen Bekleyiniz");
            Thread.Sleep(500);
            goto menu;


        }


        }
    }

