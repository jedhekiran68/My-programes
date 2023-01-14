using System.Collections.Generic;
using System.Security.Cryptography;

class program
{
    static void Main(string[] args)
    {
        /*
        list<int> v1= new List<int>();                       // list
        v1.Add(10);
        v1.Add(20);
        v1.Add(30);                                          // allow duplicate element
        v1.Add(40);

        foreach (int t in v1)
        {
            Console.WriteLine(t);
        }
    */

        /*
        HashSet<string> v1 = new HashSet<string>();           // hashSet
        v1.Add("jedhe");
        v1.Add("kiran");
        v1.Add("FRIENDS");                                    // not allow duplicate element
        v1.Add("vinayak");
        v1.Add("ambike");

        foreach (string t1 in v1)
        {
            Console.WriteLine(t1);
        }
        */

        /*
        SortedSet<string> s1= new SortedSet<string>();            // SortedSet

        s1.Add("sirname-jedhe");
        s1.Add("name-kiran");                                    // not allow duplicate element
        s1.Add("village-Ambavade");

        foreach (string s in s1)
        {
            Console.WriteLine(s);
        }
        */

        /*
        Stack<int> s1 = new Stack<int>();                              // Stack

        s1.Push(10);
        s1.Push(20);                                        // allow duplicate element
        s1.Push(30);

        s1.Pop();                                                 // last in 1'st out here

        foreach (int p in s1)
        {
            Console.WriteLine(p);
        }
        */

        /*
        Queue<string> q1 = new Queue<string>();                     // queue

        q1.Enqueue("Kiran");
        q1.Enqueue("Jedhe");                                       // allow duplicate element
        q1.Enqueue("FRIENDS");
        q1.Enqueue("Vinayak");

        q1.Dequeue();                                             // first in first out here

        foreach (string s in q1)
        { 
          Console.WriteLine(s);
        }
        */

        /*
        LinkedList<string> l1 = new LinkedList<string>();        // linked list
        l1.AddLast("a");                                      
        l1.AddLast("b");                                  //  allow duplicate element
        l1.AddLast("c");
        l1.AddLast("d");
        l1.AddLast("e");

        foreach (string s in l1)
        { 
           Console.WriteLine(s);    
        }
        */

        /*
        Dictionary<int, string> d1 = new Dictionary<int,string>();   //dictionary
        d1.Add(10,"jedhe");
        d1.Add(20,"Kiran");                                          // 20 is key and kiran is value
        d1.Add(30,"FRIENDS");                                        // key not allow duplicate value can duplicate
        d1.Add(40,"vinayak");

        foreach (KeyValuePair<int, string> s in d1)
        {
            Console.WriteLine(s.Key);
        }
        */

        /*
        SortedDictionary<string, string> s1 = new SortedDictionary<string, string>();   //sorted dictionary
        s1.Add("02","kiran");
        s1.Add("06","jedhe");                                                // 06 is key and jedhe is value
        s1.Add("02", "Friends");                                            // key not allow duplicate value can duplicate
        s1.Add("06", "vinayak");

        foreach (KeyValuePair<string, string> s in s1)
        {
            Console.WriteLine(s.Key);
        }
      */

        SortedList<int,string> s1= new SortedList<int, string>();                //sortedList

        s1.Add(10,"jedhe");                                                      // 10 is key and jedhe is value
        s1.Add(20, "kiran");
        s1.Add(30, "Friends");
        s1.Add(40, "vinayak");                                         // key not allow duplicate value can duplicate
        s1.Add(50, "Akash");

        foreach (KeyValuePair<int,string> s in s1)
        {
            Console.WriteLine(s);
        }



    }
}