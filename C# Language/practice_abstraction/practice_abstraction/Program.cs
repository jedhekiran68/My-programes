abstract class practice                                     // abstract class
{
   public abstract  void get();                             // abstract method, not write a body

    public void show()                                      // non abstract method write a body
    {
        int a = 10; int b = 20; int c ;
        c = a + b;
        Console.WriteLine(c);
    }

 }
class jk : practice                                        // child class
{
    public override void get()                                      // abstract method body
    {
        Console.WriteLine("this is abstraction practice example");
    }

}
class program                                                      // main class
{ 
  static void Main(string[] args)
    { 
        jk j1 = new jk();                                            // object of child class
        j1.get();                                                    // call abstract method
        j1.show();                                                    // call non abstract method

        Console.WriteLine("successfully executes");
    }
}