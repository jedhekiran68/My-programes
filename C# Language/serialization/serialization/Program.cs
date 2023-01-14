using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]

class jk
{
    public int no;
    public string name;

    public jk(int no, string name)
    {
        this.no = no;
        this.name = name;
    }

    class program
    {
        static void Main(string[] args)
        {

            jk j1 = new jk(10, "kiran");                                       //serialization

             String path = @"D:\file handling\serialization.pdf";

             FileStream f1 = new FileStream(path, FileMode.OpenOrCreate);

             BinaryFormatter b1 = new BinaryFormatter();

             b1.Serialize(f1, j1);

             f1.Close();

             Console.WriteLine("successfully run");
        


          
            /* 
             String path = @"D:\file handling\serialization.pdf";                       //desialization

            FileStream f1 = new FileStream(path, FileMode.OpenOrCreate);

            BinaryFormatter b1=new BinaryFormatter();

            jk j1 = (jk)b1.Deserialize(f1);

            Console.WriteLine(j1.no);

            Console.WriteLine(j1.name);
            */



            }


    }
}