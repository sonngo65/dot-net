using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NgoTatSon_Bai6
{
    
    internal class Car:Vehicle
    {
        public string color { get; set; }
        public Car()
        {
            
        }
        public Car(string id,string maker,string model,int year , double price,string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap color: ");
            color = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-10}{1,-10}", color,"");
        }
        
    }
}
