using System;
using Task2.Extensions;
using Task2.BinaryTree;
using Task2.BinaryHeap;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILab[] labs =
            {
                new BinaryTreeLab(),
                new BinaryHeapLab(),
                new MinElementsLab(15, 5)
            };

            labs.ForEach(lab => lab.Start());

            Console.ReadKey();
        }
    }
}
