
class student
{
    public int id;                         //default constructor
    public string name;
    public static string cname;        //  static constructor


    static student()                       //static constructor
    {
        cname = "apple";    
    }


    public student(int x, string y)     //parameterise constuctor
    {
        id = x;
        name = y;
    
    }

    public void display()
    {
        Console.WriteLine(id);
        Console.WriteLine(name);
        Console.WriteLine(cname);

    
    }

  

}



class proogram
{

    static void Main(string[] args)
    {

        int m;
        string n;

        Console.WriteLine("enter id:");
        m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter name:");
        n = Console.ReadLine();

        student s1 = new student(m, n);
        s1.display();
    }
        

}