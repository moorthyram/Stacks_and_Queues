

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems Using c# Generics\n");
            Console.WriteLine("Please choose below number\n1:This is Linked List.");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Stacks list = new Stacks();
                    list.AddLast(56);
                    list.AddLast(30);
                    list.AddLast(70);

                    break;
            }
            Console.ReadLine();
        }
    }
}