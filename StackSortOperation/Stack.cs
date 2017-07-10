using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;

namespace StackImplementation
{
    public class Stack
    {
        public void Stacksort(int limit)
        {
            StackOperation StackOperationobj = new StackOperation();

            int i, j;

            int[] array = new int[limit];
            for (i = 0; i < limit; i++)
            {
                Console.WriteLine("EnTER THE ARRAY");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < limit; i++)
            {
                for (j = 0; j < limit - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int tempVar = StackOperationobj.push(array[j]);
                        array[j] = array[j + 1];
                        array[j + 1] = StackOperationobj.pop();
                    }

                }
            }


            for (i = 0; i < limit; i++)
            {
                Console.WriteLine(array[i]);
            }




        }












    }
}
