using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NgoTatSon_Bai6
{
    
    internal class Program
    {   
        static List<Vehicle> Vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("1.nhap");
                Console.WriteLine("2.xuat");
                Console.WriteLine("3.sap xep theo price");
                Console.WriteLine("4.exit");
                Console.WriteLine("Chon: ");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        nhapDS();
                            break;
                   case 2:
                        xuatDS();
                        break;
                    case 3:
                        sortByPrice();
                        break;
                       case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("nhap sai vui long nhap lai: ");
                        break;
                }
                }
        }
        static void nhapDS()
        {
            Console.WriteLine("Nhap xe car: ");
            Vehicle a = new Car();
            a.Input();
            Vehicles.Add(a);
            Console.WriteLine("nhap xe truck : ");
            Vehicle b = new Truck();
            b.Input();
            Vehicles.Add(b);
        }
        static void xuatDS()
        {
            Vehicle.inTieuDe();
            foreach(Vehicle a in Vehicles)
            {
                a.Output();
            }
        }
        static void sortByPrice()
        {
            Vehicles.Sort(new Compare());
            xuatDS();
        }
    }
}
