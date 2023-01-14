class progrsm
{
    static void Main(string[] args)
    {
        String name = @"D:\CSS\image.html";
        FileInfo f1= new FileInfo(name);
        Console.WriteLine(f1.FullName);
        Console.WriteLine(f1.Name);
        Console.WriteLine(f1.Length);
        Console.WriteLine(f1.Exists);
        Console.WriteLine(f1.Extension);
        Console.WriteLine(f1.LastWriteTime.ToString());
        Console.WriteLine(f1.Attributes);
        Console.WriteLine(f1.CreationTime.ToString());
        Console.WriteLine(f1.CreationTimeUtc.ToString());
        Console.WriteLine(f1.GetObjectData);
    }
}