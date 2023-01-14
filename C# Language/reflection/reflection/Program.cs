using System.Reflection;





class program
{

    static void Main(string[] args)
    {
        /*                                               // type method
        int a = 10;
        string b = "KIRAN";

        Type t1 = a.GetType();                       //  return a which data type is used
        Type t2 = b.GetType();               

        Console.WriteLine(t1);                        // output- int32
        Console.WriteLine(t2);                        // output- string
        */

        /*
            Type t1= typeof(System.String) ;          // Get Assembly method
        Console.WriteLine(t1.Assembly);               // output-System.Private.CoreLib,
                                                      // Version=6.0.0.0, Culture=neutral,
                                                      // PublicKeyToken=7cec85d7bea7798e

        */
        /*
        Type t1= typeof(System.String);                // print type information method
        Console.WriteLine(t1.Name);                    // output- String
        Console.WriteLine(t1.FullName);                 // output- System.String
        Console.WriteLine(t1.IsAbstract);                // output-False
        */

        /*
        Type t1 = typeof(System.String);                       // print constructor method


        ConstructorInfo [] c1 = t1.GetConstructors(BindingFlags.Public | BindingFlags.Instance);  // automatic create constructor using "ctor" double tab 

        foreach(ConstructorInfo c in c1)                         // info related to constructor
        {
            Console.WriteLine(c);
        }
        */



    }

}