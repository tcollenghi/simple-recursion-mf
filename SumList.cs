using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumList
{
    //create a recursive function that write to console the number of loops it took from the parameter to 0
    public static int Sum(int i)
    {
        while (i > 0)
        {
            i--;
            Console.WriteLine(i.ToString());
        }
        Console.ReadLine();
        return i;
    }
}