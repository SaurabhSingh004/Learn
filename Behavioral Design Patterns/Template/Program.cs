using TemplateDemo;
namespace TemplateDemo
{
    public class MainApp {

    public static void main(String[] args) {

        BaseGameLoader wowLoader = new WorldOfWarcraftLoader();
        wowLoader.load();

        Console.WriteLine("=========================================");

        BaseGameLoader diabloLoader = new DiabloLoader();
        diabloLoader.load();

    }

}
}