class program
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };


        int i,sum ;
        int l = arr[0];

        for (i = 0; i<5; i++) 

        {
            if (l > arr[i])
            {
                sum = l+arr[i];

                Console.WriteLine(sum);
            }
            else {
                Console.WriteLine("no.not found");
            }
        }
    
    
    }
}