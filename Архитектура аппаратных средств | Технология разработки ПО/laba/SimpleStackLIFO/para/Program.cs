using System;
using System.Security.Cryptography;

namespace para
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStack simpleStack = new SimpleStack();

            simpleStack.Push(1);
            simpleStack.Push(2);
            simpleStack.Push(3);
            simpleStack.Push(4);
            simpleStack.Push(5);
            simpleStack.Push(6);
            simpleStack.Push(7);
            simpleStack.Push(8); 
            simpleStack.Push(9);
            simpleStack.Push(10);
            //simpleStack.Push(11);
            //simpleStack.Push(12);
            //simpleStack.Push(13);
            //simpleStack.Push(14);
            //simpleStack.Push(15);
            //simpleStack.Push(16);
            //simpleStack.Push(17);
            //simpleStack.Push(18);
            //simpleStack.Push(19);
            //simpleStack.Push(20);

            simpleStack.Pop();
            simpleStack.Pop();
            

            //simpleStack.Push(21);

            //simpleStack.isEmpty();
            //simpleStack.Size();

            //IStack c = SimpleStack.CreateStack(simpleStack);
            Console.WriteLine(simpleStack.ToString()); 
            
            
        }
        
    }

   



}








