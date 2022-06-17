namespace FlyWeightDemo
{
    public class Store {

    private  List<Book> books = new List<Book>();

    public void storeBook(String name, double price, String type, String distributor, String otherData) {
        BookType bookType = BookFactory.getBookType(type, distributor, otherData);
        books.Add(new Book(name, price, bookType));
    }

    public void displayBooks() {
     // Display books
    }

}
}