class pfunction
{
    public void addition(int x, int y)
    {
        int c = x + y;
        Console.WriteLine(c);
    }
    public void substraction(int x, int y)
    {
        int c = x - y;
        Console.WriteLine(c);
    }

    public void mult(int x, int y)
    {
        int c = x * y;
        Console.WriteLine(c);
    }

    public void division(int x, int y)
    {
        int c = x / y;
        Console.WriteLine(c);
    }
}
class program
{
    static void Main(string[] args)
    {

        pfunction add = new pfunction();
        {
            add.addition(10, 20);

            add.substraction(10, 20);

            add.mult(10, 20);

            add.division(10, 20);
        }
    }
}