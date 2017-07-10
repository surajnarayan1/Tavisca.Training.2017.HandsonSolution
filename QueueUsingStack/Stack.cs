using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackLogic
    {
        private int top=-1;
        int[] stack = new int[10];
 
        public void PushOperation(int num)
        {
            if (top < 9 )
            {
                top++;
                stack[top] = num;

         
            }
          
        }

        public int PopOperation()
        {
            if (top >-1)
            {
               ;
                return (stack[top--]);
            }
            else
                return int.MaxValue;
        }

        
        }
    }





