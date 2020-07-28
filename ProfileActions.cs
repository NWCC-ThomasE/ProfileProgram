using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ProfileProgram {
    class ProfileActions {
        public static void StartingMenu ( ) {
            List<string> actions = new List<string> { "1. Display profile values" };

            Console.WriteLine("Choose action: ");
            for (int i = 0; i < actions.Count; i++) {
                Console.WriteLine(actions[i]);
            }

            string input = Console.ReadLine();
        }
    }
}