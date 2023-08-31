using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Morgan_Daniel
{
    internal class Computer : IBootUp 
    {// implemented interface from IBOotUP, wiht string automatic properties fro Brand and Type
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }
        /// <summary>
        /// A constructor with parameters brand, type, isOn
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="type"></param>
        /// <param name="isOn"></param>
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        public void PowerOnOff() //defined public void called PowerOnOff that sets IsOn to the opposite of the current value
        {
            IsOn = !IsOn;

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }
        // An override funtion that returns a string
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";
        }
    }
}
