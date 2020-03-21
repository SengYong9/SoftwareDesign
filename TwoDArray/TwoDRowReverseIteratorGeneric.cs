//
// ICT2106 Software Design - 2D array example
//
// Concrete row-major iterator for two-dimensional arrays.
//
// Author: Nicholas Sheppard
//
namespace TwoDArray
{
    class TwoDRowReverseIteratorGeneric<T> : ITwoDIterator<T>
    {
        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;
        private bool reverse = false;

        // constructor
        public TwoDRowReverseIteratorGeneric(TwoDArrayGeneric<T> collectionIn)
        {
            collection = collectionIn;
            i = 0;
            j = 0;
        }

        // get the current element of the iteration
        public T Current()
        {
            return collection.Get(i, j);
        }

        // move to the next element of the iteration
        public void Next()
        {
            if(reverse){
                j--;
                if(j < 0){
                    j = 0;
                    i++;
                    reverse = false;
                }

            } else {
                j++;
                if (j >= collection.Columns())
                {
                    j = collection.Columns() - 1;
                    i++;
                    reverse = true;
                }
            }
        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return i >= collection.Rows();
        }
    }
}
