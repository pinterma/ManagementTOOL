using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementTOOL.DLL.CORE;
using ManagementTOOL.DLL.CORE.Object.Man;
using System.Reflection;

namespace ManagementTOOL.DLL.CORE.Object.Man
{
    public class ObjMan
    {
        public List<Provider> providers = new List<Provider>();
        public List<Profile> profiles = new List<Profile>();
        public List<Shoe> shoes = new List<Shoe>();
        public List<Transaction> transactions = new List<Transaction>();
        ConsoleMan cm = new ConsoleMan();
        ObjectWriter ow = new ObjectWriter();
        ObjectReader or = new ObjectReader();

        int id = 0;
        public void NewProvider(string alias, int budget, string name)
        {
            try
            {
                Provider provider = new Provider(alias, budget, name);
                providers.Add(provider);
                ow.SaveObjToFile("providers.txt", provider);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void NewProfile(string alias, string type, long cc_number, string pp_mail, string provider_alias)
        {
            try
            {
                    Profile profile = new Profile(alias, type, cc_number, pp_mail, provider_alias);
                    profiles.Add(profile);
                    ow.SaveObjToFile("profiles.txt", profile);
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void NewShoe(string name, int size, int price, int expected_sale, string status, DateTime date, string category, string profile)
        {
            try
            {
                if (profiles.Count == 0)
                {
                    Console.WriteLine("Please make a Profile");
                }
                else
                {
                    Shoe shoe = new Shoe(HandleID(), name, size, price, expected_sale, status, date, category, profile,false);
                    shoes.Add(shoe);
                    NewTransaction(id, price, date, profile);
                    ow.SaveObjToFile("shoes.txt", shoe);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void NewTransaction(int shoeid, int transaction_value, DateTime transaction_date, string profile)
        {
            try
            {
                Transaction transaction = new Transaction(shoeid, transaction_value, transaction_date, profile);
                transactions.Add(transaction);
                cm.AdjustBudget(providers, transaction, profiles);
                ow.SaveObjToFile("transactions.txt", transaction);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private int HandleID()
        {
            try
            {
                id++;
                return id;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ReadObjFiles()
        {
            try
            {
                List<string> paths = new List<string>();
                paths.Add("profiles.txt");
                paths.Add("providers.txt");
                paths.Add("shoes.txt");
                paths.Add("transactions.txt");

                foreach (var path in paths)
                {
                    List<string> objdata = new List<string>();
                    if (path == "profiles.txt")
                    {
                        objdata = or.ReadFile(path);
                        foreach (var obj in objdata)
                        {
                            string[] obj_ = obj.Split(';');
                            profiles.Add(new Profile(obj_[0], obj_[1], Convert.ToInt64(obj_[2]), obj_[3], obj_[4]));
                        }
                        
                    }
                    if (path == "providers.txt")
                    {
                        objdata = or.ReadFile(path);
                        foreach (var obj in objdata)
                        {
                            string[] obj_ = obj.Split(';');
                            providers.Add(new Provider(obj_[0], Convert.ToInt32(obj_[1]), obj_[2]));
                        }
                    }
                    if (path == "shoes.txt")
                    {
                        objdata = or.ReadFile(path);
                        foreach (var obj in objdata)
                        {
                            string[] obj_ = obj.Split(';');
                            shoes.Add(new Shoe(Convert.ToInt32(obj_[0]), obj_[1], Convert.ToInt32(obj_[2]), Convert.ToInt32(obj_[3]), Convert.ToInt32(obj_[4]), obj_[5], DateTime.Parse(obj_[6]), obj_[7], obj_[8], false));
                        }
                    }
                    if (path == "transactions.txt")
                    {
                        objdata = or.ReadFile(path);
                        foreach (var obj in objdata)
                        {
                            string[] obj_ = obj.Split(';');
                            transactions.Add(new Transaction(Convert.ToInt32(obj_[0]), Convert.ToInt32(obj_[1]), DateTime.Parse(obj_[2]), obj_[3]));
                        }
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private object ObjReflection(string path)
        {
            try
            {
                if (path == "")
                {

                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
