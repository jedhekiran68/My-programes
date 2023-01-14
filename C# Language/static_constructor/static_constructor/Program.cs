class jk
{

    static int no;
        static string name;
    static double  salary;

    static jk()
    {
        no = 10;
        name = "kiran";
        salary = 1000.10;

        Console.WriteLine("this is a ststic constructor");
    
    
    }

    public jk()
    {
        Console.WriteLine(no);
        Console.WriteLine(name);
        Console.WriteLine(salary);
    }


}






class program
{
    static void Main(string[] args)
    {
        jk j1 = new jk();
        
    
    }

}