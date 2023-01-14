class first
{
   public int a = 45, b = 45, c;
   
}

class program
{
    static void Main(string[] args)
    {
        first f1 = new first();
        f1.c = f1.a + f1.b;
        Console.WriteLine(f1.c);
        Console.ReadLine();
    }

}