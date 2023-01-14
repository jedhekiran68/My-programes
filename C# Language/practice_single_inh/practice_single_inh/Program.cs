using System.Data;

class practice                                                                   // 1 base class
{
    public void get()                                                            // method
    {
        Console.WriteLine("this is a single inheritance practice example");   // body
    }
}
class jk:practice                                                                // 1 child class implements base class
{
    public void show()                                                            // method
    {      
        int a = 20; int b = 30;int c = a + b;                                    // body
        Console.WriteLine(c); 
    }
}
class program                                                                     // main class
{
    static void Main(string[] args)
    {
       jk j1 = new jk();                                                            // object child class
        j1.get();                                                                   // call method 
        j1.show();


        Console.WriteLine("successfully executes");
    }

}