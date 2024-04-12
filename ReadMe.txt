Hi , 

I have created console application(.Net Core) sorts a list of names first by last name and then by any given names the person may have. 
It reads names from a text file(unsorted-names-list.txt), sorts them and writes the sorted names to another text file(sorted-names-list.txt).

***To Execute the Program ***

Open a command prompt and navigate to the directory containing the compiled executable (name.sorter_1.exe).

Run the program by executing the following command:

name.sorter_1 <file-path>

*** Unit Testing ****

I've made a project called "name-sorterTest" using NUnit. There are four specific scenarios we're checking to cover all the bases.

###### Test Scenarios : ########

TestMethodWithCorrectInput: Tests the Main method with a correct input file. Verifies that the program sorts the names correctly and produces the expected output.

TestMethodWithoutpassingFile: Checks the behavior of the Main method when called without passing a file path. Verifies that the program prompts the user to enter the file path.

TestMethodWithNoFileContent: Validates the behavior of the Main method when executed with a file that contains no names. Verifies that the program handles empty files and displays an appropriate message.

TestMethodExpectingIncorrectOutput: Tests the Main method with a correct input file but expects an incorrect output. Verifies that the program produces an output that does not match the expected result.