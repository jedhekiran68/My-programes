
using System.Threading;
class practice
{
    public virtual void get()
    {
        int i;
        for (i = 0; i <= 10; i++)
        {
            Console.WriteLine("addition is :");
        }
    }
}

class jk : practice
{
    public override void get()
    {
        base.get();

        int i;
        for (i = 0; i <= 10; i++)
        {
            Console.WriteLine("multiplication is :");
        }
    }

}
class program
{
    static void Main(string[] args)
    {

        jk j1 = new jk();

        Thread t1 = new Thread(j1.get);
    }
}