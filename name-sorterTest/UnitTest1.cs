using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter_1.Tests
{
    [TestFixture]
    public class NameSortingTests
    {
        private readonly string filepath = @"C:\Users\Lenovo\Documents\unsorted-names-list.txt"; //Please chnage the location before executing the test case.


        [Test]
        public void TestMethodWithCorrectInput()
        {
            List<string> expectedoutput = new List<string>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Krishna Desai",
                "Leo Gardner",
                "Vaugh Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "London Overground",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Netherwood Road",
                "Sinclair Road",
                "London Underground",
                "Shelby Nathan Yoder",
            };

            NameSorting.Main(new string[] { filepath });

            List<string> lstoutput = File.ReadAllLines("sorted-names-list.txt").ToList();
            CollectionAssert.AreEqual(expectedoutput, lstoutput);
        }

        [Test]
        public void TestMethodWithoutpassingFile()
        {
            var stroutput = new StringWriter();
            Console.SetOut(stroutput);

            NameSorting.Main(new string[] { });

            string expectedoutput = "Please Enter the File Path\r\n";
            Assert.AreEqual(expectedoutput, stroutput.ToString());
        }

        [Test]
        public void TestMethodWithNoFileContent()
        {
            var tempfilename = Path.GetTempFileName();
            var stroutput = new StringWriter();
            Console.SetOut(stroutput);

            NameSorting.Main(new string[] { tempfilename });

            string expectedOutput = "No names found in the file\r\n";
            Assert.AreEqual(expectedOutput, stroutput.ToString());

            File.Delete(tempfilename);
        }

        [Test]
        public void TestMethodExpectingIncorrectOutput()
        {
            List<string> expectedoutput = new List<string>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "London Lindsey",
                "Mikayla Lopez",
                "Vaugh Lewis",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder",
                 "Krishna Desai",
                 "Netherwood Road",
                 "Sinclair Road",
                 "London Overground",
                 "London Underground"
            };

            NameSorting.Main(new string[] { filepath });

            List<string> lstoutput = File.ReadAllLines("sorted-names-list.txt").ToList();
            CollectionAssert.AreNotEqual(expectedoutput, lstoutput);
        }
    }
}
