using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        public static void Display()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            int q = queue.Count();
            Console.WriteLine("Count is " + q);
            Console.WriteLine("\n");
            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("Removed element is :" + queue.Dequeue());
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine("Queue is Empty");
        }
    }
}
