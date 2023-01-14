using System.Runtime.CompilerServices;

class jk
{
   public int no;
   public  string name;
   public int salary;

    public jk(int no, string name, int salary)
    {
        this.no = no;
        this.name = name;
        this.salary = salary;

        Console.WriteLine(this.no);
        Console.WriteLine(this.name);
        Console.WriteLine(this.salary);
    
    }
}




class program
{ 
  static void Main(string[] args)
    {
        jk j1 = new jk(10, "kiran", 1000);
        

    }

}