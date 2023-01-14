class a
{
    public virtual void jk()
    {
        Console.WriteLine("hello");
    
    }

}

class b : a
{

    public override void jk()
    {
        Console.WriteLine("welcome");
        base.GetHashCode();


    }

}






class program
{
    static void Main(string[] args)
    { 
    b b1 = new b();
        b1.jk();
    
    }



}