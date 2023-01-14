public class jk
{
    static void jk1()
    {

        Console.WriteLine("this is a constructor");
    }


    ~jk()
    {
        Console.WriteLine("this is a destructor");

    
    }
}


class program
{
    static void Main(string[] args)
    { 
    
    
        jk j1= new jk();
    }    
    }