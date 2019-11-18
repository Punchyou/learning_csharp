// like JAVA
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
        int a = 10;

        /* while loop execution */
        while (a < 20) {
        Console.WriteLine("value of a: {0}", a);
        a++;
        }
        
        /* for loop execution */
        for (int a = 10; a < 20; a = a + 1) {
        Console.WriteLine("value of a: {0}", a);
        }
        Console.ReadLine();
      }
   }
}