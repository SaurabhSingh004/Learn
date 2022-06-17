using System.Collections;
namespace IteratorDemo
{
    public class DepthFirstIterator<T> : Iterator<T> {
        // dfs functionality
    public bool hasNext()
    {
        // check for next element in collection is null or not
        return true;
    }

    public Vertex<T> getNext()
    {
        //Get nxt element in stack
        return null;
    }
    public void reset()
    {
        //to reset dfs traversal 
    }
    }
}