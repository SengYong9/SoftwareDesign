/** TreeNodeComposite class **/

using System;

namespace ParseTree
{
    public class TreeNodeComposite: ITreeNode{
        
        ITreeNode leftChild = null;
        ITreeNode rightChild = null;

        String arithmetic_operator;

        public void addChild(ITreeNode leftChild, ITreeNode rightChild){
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }

        public TreeNodeComposite(String arithmetic_operator){
            this.arithmetic_operator= arithmetic_operator;
        }

        public double getValue(){
            if(leftChild == null && rightChild == null){
                Console.WriteLine("Can't be calculated!");
                return 0;
            }
            else{
                double leftChild_value = leftChild.getValue();
                double rightChild_value = rightChild.getValue();

                if(arithmetic_operator == "+"){
                    return leftChild_value + rightChild_value;
                }
                else if(arithmetic_operator == "-"){
                    return leftChild_value - rightChild_value;    
                }
                else if(arithmetic_operator == "*"){
                     return leftChild_value * rightChild_value;
                }
                else if(arithmetic_operator == "/"){
                     return leftChild_value / rightChild_value;
                }
                else{
                    Console.WriteLine("This is not an arithmetic operator");
                    return 0;
                }
            }
        }
    }

}