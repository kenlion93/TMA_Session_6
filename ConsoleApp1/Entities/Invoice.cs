using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    /*
     * Khai bao class Invoice: Id, name, date, status, payment string(cash, paypal...), total double, customer string
     * 
     * Tao collection List chua 5 Invoice, su dung lambda thuc hien cac iu cau sau:
     * 
     * 1. Liet ke hoa don thanh trong 10/2017 voi hinh thuc thanh toan = Cash
     * 2. Tinh tong hoa don do customer1 mua
     * 3. Dem co bao nhiu hoa don trong nam 2017 voi status = true
     * 4. Liet ke hoa don trong 2017 co total trong khoang 5000~10000
     * 5. Ktr 1 ma hoa don da ton tai hay chua?
     */
    public class Invoice
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Boolean Status { get; set; }
        public string Payment { get; set; }
        public double Total { get; set; }
        public string Customer { get; set; }

        public void Display()
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Date: " + this.Date);
            Console.WriteLine("Status: " + this.Status);
            Console.WriteLine("Payment: " + this.Payment);
            Console.WriteLine("Total: " + this.Total);
            Console.WriteLine("Customer: " + this.Customer);

        }
    }
}
