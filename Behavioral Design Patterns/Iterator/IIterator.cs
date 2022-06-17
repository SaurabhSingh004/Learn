namespace IteratorDemo
{
    public interface Iterator<T> {

        bool hasNext();
        Vertex<T> getNext();
        void reset();

}
}