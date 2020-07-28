using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ProfileProgram {
    class ProfileControl {
        public static void ReadExistingProfile ( string fileDir, List<string> items, List<string> currentProf ) {
            List<string> profValues = File.ReadAllLines(fileDir).ToList();

            for (int i = 0; i < items.Count; i++) {
                Console.WriteLine(items[i] + profValues[i]);
            }

            currentProf.AddRange(profValues);
        }

        public static void CreateNewProfile ( string fileDir, List<string> items, List<string> currentProf ) {
            List<string> profValues = new List<string>();

            for (int i = 0; i < items.Count; i++) {

                Console.WriteLine(items[i]);
                string answer = Console.ReadLine();
                profValues.Add(answer);
                Console.WriteLine(answer);
                Console.WriteLine();

            }
            
            File.AppendAllLines(fileDir, profValues);

            currentProf.AddRange(profValues);
        }
    }
}