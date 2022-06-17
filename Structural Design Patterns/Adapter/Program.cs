namespace AdapterDemo
{
    public interface IRestaurantApp
    {
        void displayMenus(XmlData xmlData);

        void displayRecommendations(XmlData xmlData);

    }
    public class JsonData
    {
        
    }
    public class XmlData
    {
        
    }
    
    public class RestaurantApp : IRestaurantApp {

        public void displayMenus(XmlData xmlData) {
            // Displays menus using XML data
            Console.WriteLine("Displaying Menus using XML data...");
        }

        public void displayRecommendations(XmlData xmlData) {
            // Displays recommendations using XML data
            Console.WriteLine("Displaying Recommendations using XML data...");
        }
    }
    public class UIService {

        public void displayMenus(JsonData jsonData) {
            // Make use of the JsonData to fetch menus
        }

        public void displayRecommendations(JsonData jsonData) {
            // Make use of the JsonData to load recommendations
        }

    }
    public class UIServiceAdapter : IRestaurantApp {

        private UIService UIService;

        public UIServiceAdapter() {
            UIService = new UIService();
        }

        public void displayMenus(XmlData xmlData) {
            JsonData jsonData = convertXmlToJson(xmlData);
            Console.WriteLine("Displaying  Menus using converted JSON data...");
            UIService.displayMenus(jsonData);
        }

        public void displayRecommendations(XmlData xmlData) {
            JsonData jsonData = convertXmlToJson(xmlData);
            Console.WriteLine("Displaying  Recommendations using converted JSON data...");
            UIService.displayRecommendations(jsonData);
        }

        private JsonData convertXmlToJson(XmlData xmlData) {
            // Converts XmlData to JsonData and return it
            Console.WriteLine("Converting XML to JSON...");
            return new JsonData();
        }

    }
    public class MainApp {

        public static void Main(String[] args) {

            XmlData myData = new XmlData();

            IRestaurantApp RestoApp = new RestaurantApp();
            RestoApp.displayMenus(myData);
            RestoApp.displayRecommendations(myData);

            Console.WriteLine("=======================================================");

            UIServiceAdapter adapter=new UIServiceAdapter();
            adapter.displayMenus(myData);
            adapter.displayRecommendations(myData);

        }

    }

}