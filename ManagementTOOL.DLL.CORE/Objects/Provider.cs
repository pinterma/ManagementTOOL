using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementTOOL.DLL.CORE
{
    public class Provider
    {
        public string Alias { get; set; }
        public int Budget { get; set; }
        public string Name { get; set; }

        public Provider (string alias, int budget, string name)
        {
            Alias = alias;
            Budget = budget;
            Name = name;
        }
    }
}
