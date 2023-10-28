using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoTatSon_Bai6
{
    internal class Truck: Vehicle
    {
        public double truckload { get; set; }
        public Truck() { }
        public Truck(string id,string maker,string model,int year,double price,double truckload):base(id,maker,model,year,price) {
            this.truckload = truckload;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap truckload: ");
            truckload = double.Parse(Console.ReadLine());

        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-10}{1,-10}", "", truckload);
        }
    }
}
