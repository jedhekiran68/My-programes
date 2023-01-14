class program
{
    public static void Main(string[] args) 
    {

        /* int a = 1000, b = 10, c;

         c = a / b;

         Console.WriteLine(c);
        */

        int x, y, div, rem ;

        Console.WriteLine("enter a 1'st no:");             //user through value
        x=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter 2'nd no:");               // user through value
        y=Convert.ToInt32(Console.ReadLine());

        div = x / y ;                                      //devision

        rem = x % y;                                      //reminder
        
        Console.WriteLine("devision is :");
        Console.WriteLine(div);


       Console.WriteLine("reminder is :");
        Console.WriteLine(rem);


    }
}