using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementTOOL.DLL
{
    public class Profile
    {
        public string Alias { get; set; }
        public string Type { get; set; }

        public long CC_Number { get; set; }
        public string PP_Mail { get; set; }
        public string Provider_Alias { get; set; }

        public Profile (string alias, string type, long cc_number, string pp_mail, string provider_alias)
        {
            Alias = alias;
            Type = type;
            CC_Number = cc_number;
            PP_Mail = pp_mail;
            Provider_Alias = provider_alias;
        }


    }
}
