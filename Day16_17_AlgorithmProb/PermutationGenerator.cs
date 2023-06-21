using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17_AlgorithmProb
{
    internal class PermutationGenerator
    {
        // Iterative method to generate permutations of a string
        public static string[] GeneratePermutationsIterative(string str)
        {
            // Convert the string into a character array
            char[] characters = str.ToCharArray();

            // Initialize a list to store the permutations
            List<string> permutations = new List<string>();

            // Add the initial string to the list
            permutations.Add(new string(characters));

            // Find all permutations using Heap's algorithm
            int[] indices = new int[str.Length];
            int i = 0;

            while (i < str.Length)
            {
                if (indices[i] < i)
                {
                    // Swap characters based on the parity of i
                    if (i % 2 == 0)
                        Swap(ref characters[0], ref characters[i]);
                    else
                        Swap(ref characters[indices[i]], ref characters[i]);

                    permutations.Add(new string(characters));

                    indices[i]++;
                    i = 0;
                }
                else
                {
                    indices[i] = 0;
                    i++;
                }
            }

            return permutations.ToArray();
        }

        // Recursive method to generate permutations of a string
        public static string[] GeneratePermutationsRecursive(string str)
        {
            List<string> permutations = new List<string>();

            GeneratePermutationsRecursiveHelper(str.ToCharArray(), str.Length, permutations);

            return permutations.ToArray();
        }

        // Recursive helper function
        private static void GeneratePermutationsRecursiveHelper(char[] characters, int length, List<string> permutations)
        {
            if (length == 1)
            {
                permutations.Add(new string(characters));
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    GeneratePermutationsRecursiveHelper(characters, length - 1, permutations);

                    if (length % 2 == 1)
                    {
                        Swap(ref characters[0], ref characters[length - 1]);
                    }
                    else
                    {
                        Swap(ref characters[i], ref characters[length - 1]);
                    }
                }
            }
        }

        // Helper function to swap two characters
        private static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        // Helper method to check if two arrays are equal
        public static bool ArraysAreEqual(string[] array1, string[] array2) => array1.SequenceEqual(array2);

        // Helper method to print the permutations
        public static void PrintPermutations(string message, string[] permutations)
        {
            Console.WriteLine(message);
            foreach (string permutation in permutations)
            {
                Console.WriteLine(permutation);
            }
            Console.WriteLine();
        }
    }
}
