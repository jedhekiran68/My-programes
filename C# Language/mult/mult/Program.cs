class program {
    public static void Main(string[] args)
    {

        /*int a = 10, b = 5, c;   // by define value
         c = a * b;
         Console.WriteLine(c);
     */

        int a, b, c;
        Console.WriteLine("enter a 1'st no:");   // value given to user
        a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter 2'nd no:");
        b=Convert.ToInt32(Console.ReadLine());

        c = a * b;

        Console.WriteLine(c);

       
    
    }
}