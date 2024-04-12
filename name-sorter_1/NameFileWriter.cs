using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace name_sorter_1
{
    public class NameFileWriter : INameFileWriter
    {
        public void WriteNamesToFile(List<string> Listoutput)
        {
            foreach (var item in Listoutput)
            {
                Console.WriteLine(item.ToString());
            }
            File.WriteAllLines("sorted-names-list.txt", Listoutput);
        }
    }
}
