using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementTOOL.DLL.Object.Man;
using ManagementTOOL.DLL;

namespace ManagementTOOL.CONSOLE
{
    public class Program
    {
        static ConsoleMan cm = new ConsoleMan();
        static ObjMan om = new ObjMan();
        static ObjectWriter ow = new ObjectWriter();
        static ObjectReader or = new ObjectReader();

        static void Main(string[] args)
        {
            ow.CreateFiles();
            om.ReadObjFiles();

            while (true)
            {
                string eingabe = "";
                eingabe = ShowMenu();
                ChosenValue(eingabe);
                
            }
            
        }
        static string ShowMenu()
        {
            string eingabe = "";
            Console.WriteLine("Welcome");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1        Add new Shoe");
            Console.WriteLine("2        List Shoes");
            Console.WriteLine("3        Add new PaymentProfile");
            Console.WriteLine("4        Show PaymentProfile");
            Console.WriteLine("5        Add new PaymentProvider");
            Console.WriteLine("6        Show PaymentProvider");
            Console.WriteLine("7        Show Transactions");
            Console.WriteLine("8        Show Budget");
            Console.WriteLine("9        Show Expected Sale Volume");
            Console.WriteLine("10       Show Costs");
            Console.WriteLine("11       Show Expected Profit");
            eingabe = Console.ReadLine();
            return eingabe;
        }
        static void ChosenValue(string value)
        {
            
            string eingabe = "";
            List<string> obj = new List<string>();

            switch (value)
            {
                case "1":
                    Console.WriteLine("Name:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Size:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Price:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Expected Sale:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Status? Ordered, Shipped, in Stock, Sold");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Date:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Category? Fast Sale, Sale, Slow Sale, short HOLD, HOLD, long HOLD");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Billing Profile?");
                    obj.Add(Console.ReadLine());
                    om.NewShoe(obj[0], Convert.ToInt32(obj[1]), Convert.ToInt32(obj[2]), Convert.ToInt32(obj[3]), obj[4], DateTime.Parse(obj[5]), obj[6], obj[7]);
                    break;

                case "2":
                    foreach (Shoe shoe in om.shoes.OrderBy(x => x.Name))
                        Console.WriteLine("Name: " + shoe.Name + 
                                            Environment.NewLine + "Size: " + shoe.Size +
                                            Environment.NewLine + "Price: " + shoe.Price + 
                                            Environment.NewLine + "Exp. Sale: " + shoe.Expected_Sale +
                                            Environment.NewLine + "Status: " + shoe.Status + 
                                            Environment.NewLine + "Date: " + shoe.Date.ToString("dd-MM-yyyy") + 
                                            Environment.NewLine + "Category: " + shoe.Category +
                                            Environment.NewLine);

                    break;
                case "3":
                    Console.WriteLine("Alias:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Type: PP or CC?");
                    obj.Add(Console.ReadLine());
                    if (obj[1] == "CC")
                    {
                        Console.WriteLine("CC_Number:");
                        obj.Add(Console.ReadLine());
                        obj.Add("");
                        Console.WriteLine("Provider_Alias:");
                        obj.Add(Console.ReadLine());
                    }
                    if (obj[1] == "PP")
                    {
                        obj.Add("0");
                        Console.WriteLine("PP_Mail:");
                        obj.Add(Console.ReadLine());
                        Console.WriteLine("Provider_Alias:");
                        obj.Add(Console.ReadLine());
                    }
                    else
                    {

                    }
                    om.NewProfile(obj[0], obj[1], Convert.ToInt64(obj[2]), obj[3], obj[4]);
                    Console.WriteLine("Profile added!!");
                    Console.WriteLine();
                    break;

                case "4":
                    foreach (Profile profile in om.profiles.OrderBy(x => x.Alias))
                        Console.WriteLine("Alias: " + profile.Alias + 
                                            Environment.NewLine + "Type: " + profile.Type + 
                                            Environment.NewLine + "CC_Number: " + profile.CC_Number  + 
                                            Environment.NewLine + "PP_Mail: " +
                                            Environment.NewLine + profile.PP_Mail + 
                                            Environment.NewLine + "Profile Alias: " + profile.Provider_Alias +
                                            Environment.NewLine);

                    break;
                case "5":
                    Console.WriteLine("Alias:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Budget:");
                    obj.Add(Console.ReadLine());
                    Console.WriteLine("Name:");
                    obj.Add(Console.ReadLine());
                    om.NewProvider(obj[0], Convert.ToInt32(obj[1]), obj[2]);
                    Console.WriteLine("Provider added!!");
                    Console.WriteLine();
                    break;

                case "6":
                    foreach (Provider provider in om.providers.OrderBy(x => x.Alias))
                        Console.WriteLine("Alias: " + provider.Alias + 
                                            Environment.NewLine + "Budget: " + provider.Budget.ToString() + 
                                            Environment.NewLine + "Name: " + provider.Name +
                                            Environment.NewLine);

                    break;
                case "7":
                    foreach (Transaction transaction in om.transactions.OrderBy(x => x.Shoe_ID))
                        Console.WriteLine("Transaction: " + transaction.Transaction_Value + 
                                            Environment.NewLine + "Date: " + transaction.Transaction_Date + 
                                            Environment.NewLine + "Profile: " + transaction.Profile +
                                            Environment.NewLine);

                    break;
                case "8": //Show Budget

                    Console.WriteLine("Total Budget: " + cm.GetBudget(om.providers).ToString() +
                                            Environment.NewLine);
                    break;
                case "9":
                    Console.WriteLine("Expected Sales: " + cm.GetExpectedSaleVolume(om.shoes).ToString() +
                                            Environment.NewLine);
                    break;
                case "10":
                    Console.WriteLine("Costs: " + cm.GetCosts(om.shoes).ToString() +
                                            Environment.NewLine);
                    break;
                case "11":
                    Console.WriteLine("Costs: " + cm.GetExpectedProfit(cm.GetExpectedSaleVolume(om.shoes), cm.GetCosts(om.shoes)).ToString() +
                                            Environment.NewLine);
                    break;
            }

        }
    }
}
