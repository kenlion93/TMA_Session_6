using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }

        public void Display()
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Quantity: " + this.Quantity);
            Console.WriteLine("Status: " + this.Status);
        }
    
    }
}
