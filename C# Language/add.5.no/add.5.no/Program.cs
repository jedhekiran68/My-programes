class program
{
    public static void Main(string[] args)
    {

        int a, b, c, d, e, add;

        Console.WriteLine("enter 1'st:");
        a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter 2'nd:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter 3'rd:");
        c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter 4'th:");
        d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter 5'th:");
        e = Convert.ToInt32(Console.ReadLine());


        add = a + b + c + d + e;

        Console.WriteLine("addition of 5 no is:");
        Console.WriteLine(add);
    }
}