using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public  class Stack
    {
        public static void Display()
        {
            Stack<int> s = new Stack<int>();
            s.Push(70);
            s.Push(30);
            s.Push(56);
            Console.WriteLine("Elements in stack is:");
            foreach (int i in s) 
            {
               // Console.WriteLine("Elements in stack is:");
                Console.WriteLine(i);
            }
        }
    }
}
