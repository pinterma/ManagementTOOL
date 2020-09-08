using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManagementTOOL.DLL.CORE.Object.Man
{
    public class ObjectReader
    {
        public List<string> ReadFile(string filepath)
        {
			try
			{
				List<string> List = new List<string>();
				var lines = File.ReadLines(filepath);
				foreach (string line in lines)
				{
					List.Add(line);
				}
				return List;
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
