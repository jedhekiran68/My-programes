class student
{
    int id;
    string name;


    public student(int x, string y)
    {
        int id = x;
        string name = y;

        Console.WriteLine(id);
        Console.WriteLine(name);

    }

}

class program
{

    static void Main(string[] args)
    {

        student s1 = new student(101, "kiran");



    }


}