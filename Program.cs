using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProfileProgram
{
    class Program
    {
        static void Main()
        {
            if ( !Directory.Exists("Profiles") ) {
                Directory.CreateDirectory("Profiles");
            }

            List<string> profList = Directory.GetFiles("Profiles", "*", SearchOption.AllDirectories).Select(f => Path.GetFileName(f)).ToList();

            List<string> items = new List<string> {
                "Name: ",
                "Favorite Color: ",
                "Favorite Number: "
            };

            Console.WriteLine("Type new or existing username:");
            string userInput = Console.ReadLine();

            if ( File.Exists($"Profiles/{userInput}") ) {
                ProfileControl.ReadExistingProfile( $"Profiles/{userInput}", items);
            } else {
                ProfileControl.CreateNewProfile( $"Profiles/{userInput}", items);
            }
        }
    }
}
