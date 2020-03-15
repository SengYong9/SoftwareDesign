/**TreeNodeLeaf Class**/

using System;

namespace ParseTree{

    public class TreeNodeLeaf: ITreeNode{
        
        double value = 0.0;

        public double getValue(){
            return value;
        }

        public TreeNodeLeaf(double value){
            this.value = value;
        }

        public void addChild(ITreeNode NodeA, ITreeNode NodeB){
            throw new NotImplementedException();
        }
    }
}