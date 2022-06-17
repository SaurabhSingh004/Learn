namespace TemplateDemo
{
    public class DiabloLoader : BaseGameLoader {

    public byte[] loadLocalData() {
        Console.WriteLine("Loading Diablo files...");
        // Some Diablo Code...
        return new byte[0];
    }

    public void createObjects(byte[] data) {
        Console.WriteLine("Creating Diablo objects...");
        // Some Diablo Code...
    }

    public void downloadAdditionalFiles() {
        Console.WriteLine("Downloading Diablo sounds...");
        // Some Diablo Code...
    }

    public void initializeProfiles() {
        Console.WriteLine("Loading Diablo profiles...");
        // Some Diablo Code...
    }

}
}