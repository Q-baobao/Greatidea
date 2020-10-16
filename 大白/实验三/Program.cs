using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main (string[] args) {
            string str = Console.ReadLine ();
            char temp;
            int i;
            int other = 0;
            int[] charsum = new int[26];
            for (i = 0; i < str.Length; i++) {
                temp = str[i];
                if ((temp >= 'a') && (temp <= 'z')) {
                    charsum[temp - 'a']++;

                } else {
                    other++;
                }
            }
            for (i = 0; i < 26; i++) {
                if (charsum[i] > 0) {
                    Console.WriteLine ("The sum of char {0} is {1}", (char) ('a' + i), charsum[i]);
                }

            }
            Console.WriteLine ("number of other char is {0}", other);
            Console.ReadLine ();
        }
    }
}