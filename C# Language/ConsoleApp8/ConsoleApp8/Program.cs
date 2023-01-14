using System.ComponentModel;

class college
{
    public void get()
    {
        Console.WriteLine("College name is : AT college Bhor");
    }
}
class student: college
{
    public void get2()
    {
        Console.WriteLine("Students goes to college");
    }
}
class exam: college
{
    public void get3()
    {
        Console.WriteLine("Exams are held in college to see students potential");
    }
}
class result: college
{
    public void get4()
    {
        Console.WriteLine("Results are announced at college");
    }
}
class program
{
    static void Main(string[] args)
    {
        student s1 = new student();
        exam e1 = new exam();
        result r1 = new result();

        s1.get();
        s1.get2();

        e1.get();
        e1.get3();

        r1.get();
        r1.get4();
        Console.ReadLine();
    }
}