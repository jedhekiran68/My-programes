using System.ComponentModel;

class program
{
    static void Main(string[] args)
    {
        int a;int b; int c;

        Console.WriteLine("enter value of a");
        a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter value of b");
        b = Convert.ToInt32(Console.ReadLine());

         c = a + b;
        Console.WriteLine("addition is:" +c);


    } 
}