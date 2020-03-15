/**Week 10 Lab Submission - Question 2: Main Program(Client)**/

using System;

namespace ParseTree
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Declare and initialise object
            ITreeNode main_root = new TreeNodeComposite("*");
            ITreeNode left_root = new TreeNodeLeaf(3);
            ITreeNode right_root = new TreeNodeComposite("+");
            ITreeNode left_of_right_root= new TreeNodeLeaf(10);
            ITreeNode right_of_right_root = new TreeNodeLeaf(-5);

            right_root.addChild(left_of_right_root, right_of_right_root);

            main_root.addChild(left_root, right_root);

            //Display the result 
            Console.WriteLine("Result: "+main_root.getValue().ToString());
        }
    }
}
