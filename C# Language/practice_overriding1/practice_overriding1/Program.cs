using System.Data;

class practice
{
    public virtual void get()
    {
        int a=20; int b=50; int c;
        c = a + b;
        Console.WriteLine("base method op-"+c);   
    }
}
class jk:practice
{
    public override void get()
    {

        base.get();

        int x = 2; int y = 50; int z;
        z = x * y;
        Console.WriteLine("child class op-"+z);

    }

}




class program
{
    static void Main(string[] args)
    {
        jk j1 = new jk();
        j1.get();

    }

}