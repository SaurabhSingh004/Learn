namespace TemplateDemo;
public class WorldOfWarcraftLoader : BaseGameLoader {

    public byte[] loadLocalData() {
       Console.WriteLine("Loading local WoW files...");
        return new byte[0];
    }

    public void createObjects(byte[] data) {
        Console.WriteLine("ting WoW objects...");
    }

    public void downloadAdditionalFiles() {
        Console.WriteLine("Downloading WoW sounds...");
    }

    public void initializeProfiles() {
        Console.WriteLine("Loading WoW profiles...");
    }

}