
class practice                                            // overriding 2 method with same name and same parameter
{                                                   
    public virtual void get(int a, int b)                  // 1'st method in base class use virtual keyword
    {
        int c;
        c = a + b;
        Console.WriteLine(c);                             //  dosen't show output of this method
    }
}
class jk : practice                                        // child class implements base class
{
    public override void get(int a, int b)                   // same method in child class use override keyword
    {
        int c;
        c = a * b;
        Console.WriteLine(c);                            // only show this output because override 
    }
}
class program                                           // main class
{
    static void Main(string[] args)
    {
        jk j1 = new jk();                              // object of child class
        j1.get(10, 20);                               // call the method
    }
}