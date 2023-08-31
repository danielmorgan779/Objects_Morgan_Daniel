using System;

namespace Objects_Morgan_Daniel
{

    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Apple", "All-in-One", true); //Computer object with needed arguements 
            IBootUp myBootUp = myComputer; // IBootUp object that is assigned the computer object above
            Console.WriteLine(myComputer.Equals(myBootUp)); // prints results after comparing the two using the built in object method Equals.

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true); //Another computer object with the same assigned values of the first object
            Console.WriteLine(myComputer.Equals(myOtherComputer));// Compared and results printed to console

            string myString = myComputer.ToString(); //New string variable with the same value of ToString method.
            string myOtherString = myString; //Another string variable 

            myString = "Hi";

            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);

            //Assign to string method to a string variable
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            Console.WriteLine(myComputer.GetType()); // Called the GetType method on a computer object with printed results
            Console.WriteLine(myBootUp.GetType()); //Called GetType method on the IBootUp obect with printed results

            myOtherComputer.PowerOnOff(); // Calls the PowerOnOff method

            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains('i')); // Checks to see if the string variable contains the letter "i" and prints to console

            Console.WriteLine(myString.ToUpper()); // Calls ToUpper to myString variable
            
        }
    }
}
