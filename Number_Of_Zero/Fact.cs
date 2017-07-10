using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfZero
{
    public class Fact
    {
       public int Factoriallogic(double num,double bases)
        {
            double dec=0, i=0;
            int number = (int)num;
            while(number>0)
            {
                //Console.WriteLine("num= "+num);
                double r = number % 10;
                dec = dec +( (int)Math.Pow(bases, i) )* r;
                i++;
                number = number / 10;
            }
            //Console.WriteLine(dec);
             int Counter = 0;
             for(i=1;i<=dec;i++)
             {
                 double temp = i;

                 while (temp % 5==0)
                 { 
                     Counter++;
                     temp = temp / 5;
                 }

             }
             return Counter;
            

        }



    }
}
