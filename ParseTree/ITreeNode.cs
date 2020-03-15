/**TreeINode Interface**/

using System;

namespace ParseTree {
    public interface ITreeNode
    {
        public double getValue();
        public void addChild(ITreeNode nodeA, ITreeNode nodeB);
    }
}