using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueOperation;


namespace QueueUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {




            Queue queue = new Queue();
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter 1 for Enqueue 2 for deque \n");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if ((choice != 1) && (choice != 2))
                    {
                        Console.WriteLine("Invalid Option Please Enter valid Input 1 for enqueue 2 for deque ");

                    }
                    else if (choice == 1)
                    {
                        queue.Enqueue();
                    }
                    else
                    {
                        int ans = queue.DeQueue();
                        Console.WriteLine((ans == int.MaxValue) ? "Empty" : ans.ToString());
                    }
                }

            }
            catch (Exception e)

            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}

