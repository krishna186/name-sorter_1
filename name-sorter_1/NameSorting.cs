using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace name_sorter_1
{
    public class NameSorting
    {
        private readonly INameFileReader _fileReader;
        private readonly INameFileWriter _fileWriter;

        public NameSorting()
        {
            _fileReader = new NameFileReader();
            _fileWriter = new NameFileWriter();
        }

        public static void Main(string[] args)
        {
            try
            {

                if (args.Length != 1)
                {
                    Console.WriteLine("Please Enter the File Path");
                    return;
                }
                string filepath = args[0].ToString();
                var nameSorting = new NameSorting();
                List<string> Listinput = nameSorting._fileReader.ReadNames(filepath);

                if (Listinput.Count > 0)
                {
                    nameSorting.SortNames(Listinput);
                }
                else
                {
                    Console.WriteLine("No names found in the file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

        public void SortNames(List<string> Listinput)
        {
            var nameSorting = new NameSorting();
            List<string> Listoutput = Listinput.OrderBy(x => x.Split(' ').Last()).ThenBy(x => SplitFirstName(x)).ToList();
            nameSorting._fileWriter.WriteNamesToFile(Listoutput);
        }

        public string SplitFirstName(string name)
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
