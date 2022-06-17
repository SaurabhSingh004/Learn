namespace FlyWeightDemo
{
    public class BookFactory {

    private static  Dictionary<String, BookType> bookTypes = new Dictionary<string, BookType>();

    public static BookType getBookType(String type, String distributor, String otherData) {
        if (bookTypes.ContainsKey(type) == null) {
            bookTypes.Add(type, new BookType(type, distributor, otherData));
        }
        return bookTypes[type];
    }

}
}