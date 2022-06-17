namespace IteratorDemo
{
    public class Vertex<T> {

        private  T data;

        private bool visited;

        private List<Vertex<T>> neighbors = new List<Vertex<T>>();

}
}