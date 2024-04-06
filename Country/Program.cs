using System;
using ProvinceBL;

namespace Province
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProvList infos = new ProvList();

            TProvince one = new TProvince();
            {
                one.title = "kay butas rock formation";
                one.location = "montemeria brangay";
                one.description = "simply it is known as montemaria is a township project";
            }

            TProvince two = new TProvince();
            {
                two.title = "bato spring Resort";
                two.location = "sanpedro";
                two.description = "manmade waterfall resort";
            }
            TProvince three = new TProvince();
            {
                three.title = "taal lake";
                three.location = "tagaytay city";
                three.description = "various vantage points in the city";
            }
            TProvince four = new TProvince();
            {
                four.title = "Biak na bato national park";
                four.location = "san miguel town";
                four.description = "head quarters of the philippine revolution";
            }
            TProvince five = new TProvince();
            {
                five.title = "pampangga moderm city of clark";
                five.location = "pampangga";
                five.description = "well preserved ancestral homes, a lineup of themed";
            }



            ProvList Pinfos = new ProvList();

            Console.WriteLine("Welcome to the Province Tour List!");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose a Province:");
                Console.WriteLine("1.BATANGAS");
                Console.WriteLine("2.lAGUNA");
                Console.WriteLine("3.CAVITE");
                Console.WriteLine("4.BULACAN");
                Console.WriteLine("5.PAMPANGGA");
                Console.WriteLine();
                Console.WriteLine("Your choice:");

                String choices = Console.ReadLine();

                switch (choices)
                {
                    case "1":
                        Pinfos.DisplayProvinceInfo(one);
                        break;

                    case "2":
                        Pinfos.DisplayProvinceInfo(two);
                        break;

                    case "3":
                         Pinfos .DisplayProvinceInfo(three);
                        break;

                    case "4":
                        Pinfos .DisplayProvinceInfo(four);
                        break;

                    case "5":
                        Pinfos .DisplayProvinceInfo(five);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice!");
                        Console.WriteLine("------------------");
                        break;
                        return;
                }

            }

        }
    }
}

