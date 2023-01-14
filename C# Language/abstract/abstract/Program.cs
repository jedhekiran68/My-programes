 class first
{
    public abstract void jedhe();

    public void kiran()
    {
        Console.WriteLine("its not a abstract method used");
    }
}
class program
{ 
static void Main(string[] args)

    {
        first f1 = new first();
        f1.kiran();
    }
}