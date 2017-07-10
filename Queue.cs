using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace QueueOperation
{
    public class Queue
    {
        StackLogic s1 = new StackLogic();
        StackLogic s2 = new StackLogic();

     
      //  int[] stack = new int[10];

       // int[] stack1 = new int[10];
        public void Enqueue()
        {

            
            Console.Write("enter the element \n");
            int num = Convert.ToInt32(Console.ReadLine());

            
           s1.PushOperation(num);
            
          


        }
        public int DeQueue()
        {
            int i = s1.PopOperation(),value;
            while (i != int.MaxValue)
            {
                s2.PushOperation(i);
                i = s1.PopOperation();
            }
            value = s2.PopOperation();
            i = s2.PopOperation();
            while (i != int.MaxValue)
            {
                s1.PushOperation(i);
                i = s2.PopOperation();
            }

            return value;

        }


    }
}
