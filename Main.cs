namespace LevelReloader;

public class Main : MelonMod
{
    internal const string Name = "Level Reloader"; // Required
    internal const string Description = "Reloads the level if you hit Control R."; // Required
    internal const string Author = "SoulWithMae"; // Required
    internal const string Company = "Weather Electric"; // Set as null if blank
    internal const string Version = "1.1.0"; // Required
    internal const string DownloadLink = "https://bonelab.thunderstore.io/package/SoulWithMae/LevelReloader/"; // Set as null if blank
        
    public override void OnUpdate()
    {
        if ((Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl)) && Input.GetKeyDown(KeyCode.R))
        {
            SceneStreamer.Reload();
        }
    }
}