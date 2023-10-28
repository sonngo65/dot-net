using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoTatSon_Bai6
{
    public class Vehicle : IVehicle
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string id)
        {
            this.id = id;
        }
        public Vehicle(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap id : ");
            id = Console.ReadLine();
            Console.WriteLine("Nhap maker : ");
            maker = Console.ReadLine();
            Console.WriteLine("Nhap model: ");
            model = Console.ReadLine();
            Console.WriteLine("Nhap year : ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap price : ");
            price = double.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.Write("{0,-10}{1,-15}{2,-15}{3,-10}{4,-10}", id, maker, model, year, price);
        }
        public override bool Equals(object obj)
        {
            Vehicle vehicle = obj as Vehicle;
            return vehicle.id.Equals(this.id);
        }
        public override string ToString()
        {
            return "id : " + id  + "/ maker: " + maker + "/model: " + model + "/ year: " + year + "/price: " + price;
        }
        public static void inTieuDe() {
            Console.WriteLine("{0,-10}{1,-15}{2,-15}{3,-10}{4,-10}{5,-10}{6,-19}", "id", "maker", "model", "year", "price", "color", "truck");
        }
    }
}
