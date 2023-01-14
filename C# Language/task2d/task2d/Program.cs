using System.Xml.Schema;

class program
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };    //error

        int i, l ;
        int x=0;
        l = arr[0];

        for (i = 0; i < 5; i++)
        {
            if (l<arr[i])
                {
            x = arr[i];

        }
        }
    int r, le;
    r=l%10;
        le=l/10;
         int t;
     t=r+le;
        arr[x]=t;
     Console.WriteLine("display array:");
        for(i=0;i<5;i++)
        {
        Console.WriteLine(arr[i]);
        }


    }
}