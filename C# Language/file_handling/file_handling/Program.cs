using System.Runtime.CompilerServices;

class program
{
    static void Main(string[] args)
    {
        try
        {
            string path = @"D:\file handling\1.txt";
            
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("this is a writeline function in file handling concept");

            Console.WriteLine(path);

            
            
          }

        catch (Exception)
        { 
        
        
        Console.WriteLine("this is exception handling");
        
        
        
        }
    
    
    
    
    
    
    
    }


}