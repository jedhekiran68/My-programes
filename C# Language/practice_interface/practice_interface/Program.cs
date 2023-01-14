interface practice                                                 //  interface class 
{                                                                  // we can use only method decaration
    public void get();                                              // interface method  
    public void show();                                             // interface method 
}   
interface jk                                                        // again interface class
{
    public void kiran();                                             // interface method
}

class jedhe : practice                                               // child class
{
    public void get()                                                 // interface method body
    {
        Console.WriteLine("this is a interface practice example");
    }
    public void show()                                                     // interface method body
    {
        int a = 50; int b = 10; int c = a - b;
        Console.WriteLine(c);
    }
}
class kaju : jk                                                                // 2'nd interface child class
{
    public void kiran()                                                         // interface method body
    {
        Console.WriteLine("this is a interface");
    }
}
class program                                                    // main class
{
    static void Main(string[] args)
    {
        jedhe j1 = new jedhe();                                // 1'st child class object
        j1.get();                                               // call method
        j1.show();

        kaju k1 = new kaju();                                  // 2' nd child class object 
        k1.kiran();                                            // call method

        Console.WriteLine("successfully executes");
    }
}