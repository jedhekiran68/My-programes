using System.IO.Pipes;

class program
{
    public static void Main(string[] args)
    {

        int no  ;

        Console.WriteLine("enter a no:");
        no=Convert.ToInt32(Console.ReadLine());

        if(no%2==0)
         {
            
            Console.WriteLine("positive no.");

            }

        else
        {

            Console.WriteLine("negative no.");

        }
    }
}