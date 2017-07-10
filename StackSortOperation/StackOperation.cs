using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class StackOperation
    {

        int[] Stack = new int[10];
        int top = -1;
        public int push(int item)
        {
            top++;
            Stack[top] = item;
            return Stack[top];
        }
        public int  pop()
        {
            int popedvalue = Stack[top--];
            return popedvalue;
        }
    }
}
