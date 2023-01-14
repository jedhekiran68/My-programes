class practice
{
    public void get(ref int x)
    {
        int x = x + 10;
        Console.WriteLine("method ans=" + x);
    }
}
class program
{
    static void Main(string[] args)
    {
        int x = 50;
        practice p1 = new practice();
        Console.WriteLine("value before calling" + x);
        p1.get(ref x);
        Console.WriteLine("value after calling" + x);
    }
}