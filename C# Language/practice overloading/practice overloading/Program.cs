
class practice                                                // method overloading with same name diffrent parameter 
{                                                             // multiple method in same class
                                                                    
    public void get(int a)                                    // 1'st method only 1 parameter
    {
        Console.WriteLine(a);
    
    }
   public void get(int a, int b)                              // 2'nd method 2 parameter
    { 
    Console.WriteLine("value of a:" + " " + a);
        Console.WriteLine("value of b:" + " " + b);
    
    }

    public void get(int a, int b , int d)                   // 3'rd method 3 parameter
    {
        int c = a + b;
        Console.WriteLine("addition is:" + " " + c);

        Console.WriteLine("value of d:" + " " + d);
    }
}

class program                                             // main class
{
    static void Main(string[] args)
    {
        practice p1 = new practice();                // object of classs
      
        p1.get(2);                                  // call 1'st parameter method pass only 1 parameter

        //  p1.get(5,8);                               // call 2'nd parameter method pass only 2 parameter

        //  p1.get(10,20,6);                         // call 3'rd parameter method pass only 3 parameter
    }
}