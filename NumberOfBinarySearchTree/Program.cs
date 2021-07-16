using System;

namespace NumberOfBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Binary Search tree with n node");
            int trees=NumberOfBST.NumberOfTrees(3);
            Console.WriteLine("Total number of tress ={0}",trees);
        }
    }
}
