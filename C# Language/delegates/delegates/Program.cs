using static practice;

class practice
{
    public delegate void calculator(int a, int b);

    public void add(int a,int b)
    {
        int c = a = b;
        Console.WriteLine(c);
    
    }

    public void sub(int a, int b)
    {
        int c = a - b;
        Console.WriteLine(c);
    }

    public void mult(int a, int b)
    {
        int c = a * b;
        Console.WriteLine(c);
    }

    public void div(int a, int b)
    {
        int c = a / b;
        Console.WriteLine(c);
    }

}

class program
{
    static void Main(string[] args)
    {
        practice p1 = new practice();

        calculator c1 = new calculator(p1.add);
        c1.Invoke(10, 20);

        calculator c2 = new calculator(p1.sub);
        c2.Invoke(10, 20);

        calculator c3= new calculator(p1.mult);
        c3.Invoke(10, 20);

        calculator c4 = new calculator(p1.div);
        c4.Invoke(100, 20);

    }

}