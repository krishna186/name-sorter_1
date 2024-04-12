using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace name_sorter_1
{
    public class NameSorting
    {
        public static void Main(string[] args)
        {
            try
            {
                
                if (args.Length != 1)
                {
                    Console.WriteLine("Please Enter the File Path");
                    return;
                }
                string filepath =  args[0].ToString();
                List<string> Listinput = File.ReadAllLines(filepath).ToList();
                if (Listinput.Count > 0)
                {
                    List<string> Listoutput = Listinput.OrderBy(x => x.Split(' ').Last()).ThenBy(x => SplitFirstName(x)).ToList();
                    foreach (var item in Listoutput)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    File.WriteAllLines("sorted-names-list.txt", Listoutput);
                }
                else
                {
                    Console.WriteLine("No names found in the file");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

        public static string SplitFirstName(string name)
        {
            string[] strsplit = name.Split(' ');
            StringBuilder str = new StringBuilder();
            for (int i = 0; i <= strsplit.Length - 1; i++)
            {
                str.Append(strsplit[i].ToString() + " ");              
            }

            return str.ToString();
        }
    }
}
