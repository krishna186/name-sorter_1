using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter_1
{
    internal interface INameFileReader
    {
        List<string> ReadNames(string filePath);
    }
}
