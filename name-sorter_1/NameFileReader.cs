using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace name_sorter_1
{
    public class NameFileReader : INameFileReader
    {
        List<string> INameFileReader.ReadNames(string filepath)
        {
            return File.ReadAllLines(filepath).ToList();
        }
    }
}
