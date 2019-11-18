using System;


namespace TypeConversionApp {
     // Explicit type conversion
    class ExplicitConversion{
        static void ExplicitConver()
    {
        double d = 5.32;
        int i;

        // cats double to int
        i = (int)d;
        Console.WriteLine(i);
        Console.ReadKey();
    }
    }
    // Implicit type conversion
    class ImplicitConversion{
        static void Main () {
            int i = 3;
            char j = Convert.ToChar(i);
            Console.WriteLine("The new type is : {0}", j.GetType());
            Console.ReadKey();
        }
    }
        
}