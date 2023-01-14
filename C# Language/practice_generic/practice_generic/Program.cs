class practice
{
    public void get<T>(T a,T b)                                    //   generic method use <T>
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
     }
}
class program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("enter value a");                        // value get by user but error occur
        a = Console.ReadLine();

       Console.WriteLine("enter value b");
        b = Console.ReadLine();
           */

        practice p1 = new practice();                             // object
        // p1.get(a,b);
     

       p1.get(2, 3);                                         // call the method
    
    }
}