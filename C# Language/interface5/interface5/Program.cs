interface jk
{
    public void addition();

    public void sub();

    public void mult();


}

class kiran : jk
{
    public void addition()
    {
        int a = 10, b = 20, c;
        c = a + b;
        Console.WriteLine(c);
    }

    public void sub()
    {
        int a = 10, b = 20, c;
        c = a - b;
        Console.WriteLine(c);
    }

    public void mult()
    {
        int a = 10, b = 20, c;
        c = a * b;
        Console.WriteLine(c);


    }


}
class program
{
    static void Main(string[] args)
    {

        kiran k1 = new kiran();
        k1.addition();
        k1.sub();
        k1.mult();


    }

}