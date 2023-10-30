using System;
using System.IO;
using System.Data;

public class test {

    public void testfunction() {
        Dictionary<object, int> m = new Dictionary<object, int>();
        Object o1 = new Object(); 
        //Object o2 = o1;
        Console.WriteLine(m[o1]);
    }

    public void countwordinarray()
    {
        string[] str = { "the", "dog", "the", "test" };
        bool[] visited = new bool[str.Length];

        // Traverse through array elements and
        // count frequencies
        for (int i = 0; i < str.Length; i++)
        {

            // Skip this element if already processed
            if (visited[i] == true)
                continue;

            // Count frequency
            int count = 1;
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    visited[j] = true;
                    count++;
                }
            }
            Console.WriteLine(str[i] + " " + count);
        }
    }


    static void Main()
{
    test obb = new test();
    obb.countwordinarray();

}

}