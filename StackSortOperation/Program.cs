using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;

namespace StackSortOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please press the limit of array");
            int limit = Convert.ToInt32(Console.ReadLine());

            //stackobj.stackoStacksort( limit);
            Stack stackobj = new Stack();
            stackobj.Stacksort(limit);
            Console.ReadKey();
        }
    }
}
