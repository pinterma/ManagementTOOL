using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementTOOL.DLL.Object.Man
{
    public class ConsoleMan
    {
        
        public List<string> NewShoe()
        {
            
            return null;
        }
        public int GetBudget(List<Provider> providers)
        {
            try
            {
                int budget = 0;
                foreach (Provider provider in providers)
                {
                    budget = budget + provider.Budget;
                }
                return budget;
            }
            catch (Exception)
            {

                throw;
            }
        
        }
        public void AdjustBudget(List<Provider> providers, Transaction transaction, List<Profile> profiles)
        {
            try
            {
                foreach (Profile profile in profiles)
                {
                    if (transaction.Profile == profile.Alias)
                    {
                        foreach (Provider provider in providers)
                        {
                            if (provider.Alias == profile.Provider_Alias)
                            {
                                provider.Budget = provider.Budget - transaction.Transaction_Value;
                                
                            }
                        }
                        
                    }
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int GetExpectedSaleVolume(List<Shoe> shoes)
        {
            try
            {
                int volume = 0;
                foreach (Shoe item in shoes)
                {
                    volume = volume + item.Expected_Sale;
                }
                return volume;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int  GetCosts(List<Shoe> shoes)
        {
            try
            {
                int volume = 0;
                foreach (Shoe item in shoes)
                {
                    volume = volume + item.Price;
                }
                return volume;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int GetExpectedProfit(int expected_sales, int costs)
        {
            try
            {
                int volume = 0;
                volume = expected_sales - costs;
                return volume;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public void 
    }
}
