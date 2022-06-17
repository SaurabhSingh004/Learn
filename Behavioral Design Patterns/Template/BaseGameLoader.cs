namespace TemplateDemo
{
    public abstract class BaseGameLoader {

    public void load() {
        byte[] data = loadLocalData();
        createObjects(data);
        downloadAdditionalFiles();
        cleanTempFiles();
        initializeProfiles();
    }

    public abstract byte[] loadLocalData();

    public abstract void createObjects(byte[] data);

    public abstract void downloadAdditionalFiles();

    public abstract void initializeProfiles();

    protected void cleanTempFiles() {
        Console.WriteLine("Cleaning temporary files...");
        // Some Common Code...
    }

}
}