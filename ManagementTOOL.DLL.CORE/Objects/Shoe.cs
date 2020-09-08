using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementTOOL.DLL.CORE
{
    public class Shoe
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public int Size { get; set; }
        public int Price { get; set; }
        public int Expected_Sale { get; set; }

        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

        public string Profile { get; set; }

        public bool Sold { get; set; }

        public Shoe (int id, string name, int size, int price, int expected_sale, string status, DateTime date, string category, string profile, bool sold)
        {
            Sold = sold;
            ID = id;
            Name = name;
            Size = size;
            Price = price;
            Expected_Sale = expected_sale;
            Status = status;
            Date = date;
            Category = category;
            Profile = profile;
        }

    }
}
