using System;
using System.Text;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the first string that will be used for concatenation.
            string firstName = "John";


        // Create the second string that will be used for concatenation.
        string middleName = "Michael";

            // Create the third string that will be used for concatenation.
            string lastName = "Smith";

            // Concatenate the three strings together to create a full name.
            string fullName = firstName + " " + middleName + " " + lastName;

            // Display the concatenated full name on the console.
            Console.WriteLine("Full Name: " + fullName);

            // Convert the full name string to uppercase letters.
            string upperCaseName = fullName.ToUpper();

            // Display the uppercase version of the full name.
            Console.WriteLine("Uppercase Name: " + upperCaseName);

            // Create a StringBuilder object that will be used to build a paragraph.
            StringBuilder paragraph = new StringBuilder();

            // Add the first sentence to the StringBuilder.
            paragraph.Append("Learning C# is an important part of becoming a better programmer. ");

            // Add the second sentence to the StringBuilder.
            paragraph.Append("Strings are useful for storing and working with text. ");

            // Add the third sentence to the StringBuilder.
            paragraph.Append("The StringBuilder class makes it easy to build longer pieces of text. ");

            // Add the fourth sentence to the StringBuilder.
            paragraph.Append("Practicing these skills helps me become more comfortable with C#.");

            // Display the completed paragraph on the console.
            Console.WriteLine("Paragraph:");
            Console.WriteLine(paragraph.ToString());

            // Pause the program so the console window stays open.
            Console.WriteLine("\nPress any key to exit.");

            // Wait for the user to press a key before closing the program.
            Console.ReadKey();
        }
    }


}
