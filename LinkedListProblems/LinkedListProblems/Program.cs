using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations obj = new Operations();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertBetween(2, 30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("*************************");
            obj.Display();
        }
    }
}
