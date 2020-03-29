//
// ICT2106 Software Design - 2D array example
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 2 x 3 array of integers
            ITwoDArray<string> array = new TwoDArrayGeneric<string>(2, 3);
            array.Set(0, 0, "Sarah"); array.Set(0, 1, null); array.Set(0, 2, "Yixin");
            array.Set(1, 0, "Seng yong"); array.Set(1, 1, null); array.Set(1, 2, "Faizal");

            // display the array in row major order
            ITwoDIterator<string> iter = array.CreateRowMajorIterator();
            Console.Write("\n --Iterator-- \n");
            while (!iter.IsDone())
            {
                Console.Write(iter.Current() + " ");
                iter.Next();
            }

            // create and fill an array of name including nulls
            ITwoDArray<string> nameArray = new TwoDArrayGeneric<string>(2,3);
            nameArray.Set(0, 0, "Sarah"); nameArray.Set(0, 1, null); nameArray.Set(0, 2, "Yixin");
            nameArray.Set(1, 0, "Seng yong"); nameArray.Set(1, 1, null); nameArray.Set(1, 2, "Faizal");
            
            // display the array in reverse row major order
            ITwoDIterator<string> iterReverse = nameArray.CreateRowReverseIterator();
            Console.Write("\n\n --Reverse Iterator-- \n");
            while (!iterReverse.IsDone())
            {
                Console.Write(iterReverse.Current() + " ");
                iterReverse.Next();
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
