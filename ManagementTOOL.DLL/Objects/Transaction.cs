using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementTOOL.DLL
{
    public class Transaction
    {
        public int Shoe_ID { get; set; }
        public int Transaction_Value { get; set; }
        public DateTime Transaction_Date { get; set; }
        public string Profile { get; set; }
        public Transaction(int shoe_id, int transaction_value, DateTime transaction_date, string profile)
        {
            Shoe_ID = shoe_id;
            Transaction_Value = transaction_value;
            Transaction_Date = transaction_date;
            Profile = profile;
        }
    }
}
