class practice                                                                    // 1 base class
{
    public void get()                                                              // method
    {
        Console.WriteLine("this is the base class");
    
    }
}
 class A:practice                                                                   // 1 derived class
{
    public void jk()                                                               // method
    {
        Console.WriteLine("this is a derived class implements practice class");
    }

}

class B : A                                                                          //2 derived class
{
    public void show()                                                                // method
    {
        Console.WriteLine("this is a derived class implements A class");
    }
}

class C : B                                                                           // 3 derived class 
{
    public void display()                                                             // method
    {
        int a = 10;int b = 8;int c = a * b;
        Console.WriteLine(c);
    }
}

class Program                                                                       // main class
{
    static void Main(string[] args)
    {
        C c1 = new C();                                                           // last derived class object
        c1.get();                                                                  //call base class method
        c1.jk();                                                                  // call 1 derived class method
        c1.show();                                                                 // call 2 derived class method
        c1.display();                                                              // call 3 derived class method

        Console.WriteLine("successfully executes");
    }

}