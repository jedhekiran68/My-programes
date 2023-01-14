
class practice                                                     // 1 base class
{
    public void get()
    {
        Console.WriteLine("this is a base class of herarchical inheritance practice example");
    }
}

class A : practice                                                              // 1 derived class implements base class
{
    public void show()
    {
        Console.WriteLine("this is a derived class A implements class practice");
    }
}

class B : practice                                                             // 2 derived class implements base class
{
    public void display()
    {
        Console.WriteLine("this is a derived class B implements class practice");
    }

}

class C : practice                                                              // 3 derived class implements base class
{
    public void jk()
    {
        int a = 20;int b = 5; int c = a * b;
        Console.WriteLine(c);
    }
}


class program                                                               // main class 
{
    static void Main(string[] args)
    {
     C c1= new C();                                                      // 3 derived class object
        c1.get();                                                       // call base class method
        c1.jk();                                                        // call self method

        B b1 = new B();                                                      // 2 derived class object
        b1.get();                                                             // call base class method
        b1.display();                                                          // call self method

        A a1 = new A();                                                      // 1 derived class object
        a1.get();                                                           // call base class method
        a1.show();                                                              // call self method

        Console.WriteLine("successfully executes");
    }
}