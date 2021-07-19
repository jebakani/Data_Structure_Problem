using System;

namespace NumberOfBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Binary Search tree with n node");
            long trees=NumberOfBST.NumberOfTrees(100);
            Console.WriteLine("Total number of tress ={0}",trees);
        }
    }
}
