public class practice                                              //inheritance class
{
    public practice()                                              // inheritance methodth same name of class
    {
        Console.WriteLine("this is a inheritance ");
    }
    public void get()                                                   //non-inheritance method
    {
        int a = 2; int b = 4; int c = a * b; 
        Console.WriteLine(c);
    }

}

public class jk : practice                                                 // child class inherites class
{
    public jk()                                                             // child class method 
    {
        Console.WriteLine("this is a child class of practice class");
    }
}
class program                                                            // main class 
{
    static void Main(string[] args)
    {
        jk j1 = new jk();                                               // child class object 
        j1.get();                                                      // call  non inherited method


        Console.WriteLine("successfuly executes");
    }
}