using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ManagementTOOL.DLL.CORE.Object.Man
{
    public class ObjectWriter
    {        
        public void CreateFiles()
        {
            try
            {
                if (File.Exists("shoes.txt"))
                {

                }
                else
                {
                    File.Create("shoes.txt").Close();
                }
                if (File.Exists("profiles.txt"))
                {

                }
                else
                {
                    File.Create("profiles.txt").Close();
                }
                if (File.Exists("providers.txt"))
                {

                }
                else
                {
                    File.Create("providers.txt").Close();
                }
                if (File.Exists("transactions.txt"))
                {

                }
                else
                {
                    File.Create("transactions.txt").Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void SaveObjToFile(string path, object o)
        {
            try
            {
                string data = ToCsv<object>(";", o);
                File.AppendAllText(path, data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static string ToCsv<T>(string separator, object o)
        {

            Type t = o.GetType();
            PropertyInfo[] properties = t.GetProperties();

            string header = String.Join(separator, properties.Select(f => f.Name).ToArray());

            StringBuilder csvdata = new StringBuilder();
            csvdata.AppendLine(ToCsvFields(separator, properties, o));

            return csvdata.ToString();
        }

        private static string ToCsvFields(string separator, PropertyInfo[] properties, object o)
        {
            StringBuilder linie = new StringBuilder();

            foreach (var f in properties)
            {
                if (linie.Length > 0)
                    linie.Append(separator);

                var x = f.GetValue(o);

                if (x != null)
                    linie.Append(x.ToString());
            }

            return linie.ToString();
        }
    }
}
