class student
{
    int x;
    string y;

    public student(int m, string n)
    {
        x = m;
        y = n;

        Console.WriteLine(x);
        Console.WriteLine(y);
    }

    public student(student ss)
    {
        x = ss.x;
        y = ss.y;
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}
class program
{ 
  static void Main(string[] args)
    {

            student s1 = new student(101, "kiran");
            student s2 = new student(s1);



    }
}