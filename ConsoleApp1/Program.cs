using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo7();
            Console.ReadLine();
        }

        static void Demo1()
        {
            IHuman ihuman = new Human();
            ihuman.Action1();
            ihuman.Action2();

            IB ib = new Human();
            ib.B1();
            ib.B2();
        }

        static void Demo2()
        {
            List<string> names = new List<string>();
            names.Add("Name 1");
            names.Add("Name 2");
            names.Add("Name 3");
            names.Add("Name 4");

            Console.WriteLine("Size: " + names.Count);
            for (var i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("-----------/////----------");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Demo3()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = "p01", Name = "Nokia", Price = 2, Quantity = 3, Status = true });
            products.Add(new Product() { Id = "p02", Name = "Iphone", Price = 5, Quantity = 5, Status = true });
            products.Add(new Product() { Id = "p03", Name = "Xiaomi", Price = 1, Quantity = 10, Status = false });

            Console.WriteLine("Product List\n");

            for (var i = 0; i < products.Count; i++)
            {
                products[i].Display();
                Console.WriteLine("\n---------------------");
            }

            foreach (Product product in products)
            {
                product.Display();
                Console.WriteLine("\n---------------------");
            }
        }

        static void Demo4()
        {
            //Lamda
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = "p01", Name = "Nokia", Price = 2, Quantity = 3, Status = true });
            products.Add(new Product() { Id = "p02", Name = "Iphone", Price = 8, Quantity = 5, Status = true });
            products.Add(new Product() { Id = "p03", Name = "Xiaomi", Price = 1, Quantity = 10, Status = false });

            Console.WriteLine("Product List\n");

            /*
            products.ForEach(p =>
            {
                p.Display();
                Console.WriteLine("\n----------------");
            });

            products.Where(p => p.Price >= 1 && p.Price <= 7).ToList().ForEach(p =>
            {
                p.Display();
                Console.WriteLine("\n----------------");
            });

            //StartWith, EndWith, Contains
            products.Where(p => p.Name.Contains("No")).ToList().ForEach(p => {
                p.Display();
                Console.WriteLine("\n----------------");
            });

            //OrderBy, OrderByDescending, 
            products.OrderByDescending(p => p.Price).Skip(0).Take(2).ToList().ForEach(p => {
                p.Display();
                Console.WriteLine("\n----------------");
            });
            */

            /*
            var result1 = products.Sum(p => p.Quantity);
            Console.WriteLine("Result 1: " + result1);

            var result2 = products.Sum(p => p.Price * p.Quantity);
            Console.WriteLine("Result 2: " + result2);

            var result3 = products.Where(p => p.Status)
                                  .Sum(p => p.Price * p.Quantity);
            Console.WriteLine("Result 3: " + result3);
            */
            var rsl = products.Count(p => p.Status);
            Console.WriteLine("Count: " + rsl);

            var min = products.Min(p => p.Price);
            var max = products.Max(p => p.Price);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }

        static void Demo5()
        {
            //Date && Time

            DateTime today = DateTime.Now;
            Console.WriteLine("Today: " + today.ToString("dd/MM/yyyy HH:mm:ss\n"));

            Console.WriteLine("Year: " + today.Year);
            Console.WriteLine("Month: " + today.Month);
            Console.WriteLine("Date: " + today.Day);

            //Ep chuoi
            string birthday = "10/20/2018";
            DateTime dob = Convert.ToDateTime(birthday);
            Console.WriteLine("\nYear: " + dob.Year);

        }

        static void Demo6()
        {
            /*
             * Nhap 1 dob va thuc hien:
             * 1. Ktra hom nay fai sinh nhat ko
             * 2. Ktra tuoi du 18 chuaw
             */

            Console.WriteLine("Nhap ngay thang nam sinh (mm/dd/yyyy)");
            DateTime bd = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Now;

            if (bd.Date == today.Date && bd.Month == today.Month)
            {
                Console.WriteLine("Chuc mung sinh nhat");
            }
            else
            {
                Console.WriteLine("Rang doi toi sinh nhat di ban");
            }

            if (today.Year - bd.Year >= 18)
            {
                Console.WriteLine("Du 18 tuoi roi");
            }
            else
            {
                Console.WriteLine("Rang doi toi 18 tuoi di");
            }

        }

        static void Demo7()
        {
            List<Invoice> invoices = new List<Invoice>();
            invoices.Add(new Invoice() { Id = "i01", Name = "Invoice 1", Date = Convert.ToDateTime("10/07/2017"), Status = true, Payment = "Cash", Total = 1500, Customer = "Customer 1" });
            invoices.Add(new Invoice() { Id = "i02", Name = "Invoice 2", Date = Convert.ToDateTime("10/01/2018"), Status = true, Payment = "Paypal", Total = 6000, Customer = "Customer 2" });
            invoices.Add(new Invoice() { Id = "i03", Name = "Invoice 3", Date = Convert.ToDateTime("10/11/2017"), Status = false, Payment = "Cash", Total = 11100, Customer = "Customer 3" });
            invoices.Add(new Invoice() { Id = "i04", Name = "Invoice 4", Date = Convert.ToDateTime("20/03/2017"), Status = true, Payment = "Cash", Total = 1750, Customer = "Customer 1" });
            invoices.Add(new Invoice() { Id = "i05", Name = "Invoice 5", Date = Convert.ToDateTime("10/10/2017"), Status = false, Payment = "Cash", Total = 8000, Customer = "Customer 2" });

            Console.WriteLine("Invoide list");
            DateTime today = DateTime.Now;
            int a = 0;
            switch(a)
            {
                case 1:
                    //1. Liet ke hoa don thanh trong 10/2017 voi hinh thuc thanh toan = Cash
                    invoices.Where(p => p.Date.Month == 7 && p.Date.Year == 2017 && p.Payment == "Cash")
                            .ToList()
                            .ForEach(p => {p.Display();
                            });
                    
                    break;


                default:
                    break;
            }
        }
    }
}