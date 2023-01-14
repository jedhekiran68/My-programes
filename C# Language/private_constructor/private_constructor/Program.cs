
class jk
{
    private jk()
    {
        Console.WriteLine("this is a private constructor and this is not call by object");

    
    }

    public jk()
    {
        static void jk1()
        {
            Console.WriteLine("this is private constructor but if u call they we used to static constructor");
        }
    }



}
class program
{ 
 static void Main(string[] args)
    {

        jk.jk1();
    }
    
 }