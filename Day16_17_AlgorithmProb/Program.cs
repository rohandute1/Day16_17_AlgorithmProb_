using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17_AlgorithmProb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            Console.WriteLine("Please choose any one option from following");
            Console.WriteLine(" 1.Permutation generator\n ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter any string to do permutation");
                    string input = Console.ReadLine();

                    // Generate permutations using iterative method
                    string[] permutationsIterative = PermutationGenerator.GeneratePermutationsIterative(input);

                    // Generate permutations using recursive method
                    string[] permutationsRecursive = PermutationGenerator.GeneratePermutationsRecursive(input);

                    // Check if the arrays are equal
                    bool arraysAreEqual = PermutationGenerator.ArraysAreEqual(permutationsIterative, permutationsRecursive);

                    // Print permutations and array equality
                    PermutationGenerator.PrintPermutations("Permutations generated using the iterative method:", permutationsIterative);
                    PermutationGenerator.PrintPermutations("Permutations generated using the recursive method:", permutationsRecursive);
                    Console.WriteLine("Are the arrays equal? " + arraysAreEqual);
                    break;

            }
            Console.ReadLine();
        }
    }
}
