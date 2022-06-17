namespace FlyWeightDemo
{
    public class Book {
    private  String name;
    private  double price;
    private  BookType type;
    public Book(String name, double price, BookType type)
    {
        this.name=name;
        this.type=type;
        this.price=price;
    }
    

}
}