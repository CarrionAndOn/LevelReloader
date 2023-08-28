using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(LevelReloader.Main.Description)]
[assembly: AssemblyDescription(LevelReloader.Main.Description)]
[assembly: AssemblyCompany(LevelReloader.Main.Company)]
[assembly: AssemblyProduct(LevelReloader.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + LevelReloader.Main.Author)]
[assembly: AssemblyTrademark(LevelReloader.Main.Company)]
[assembly: AssemblyVersion(LevelReloader.Main.Version)]
[assembly: AssemblyFileVersion(LevelReloader.Main.Version)]
[assembly:
    MelonInfo(typeof(LevelReloader.Main), LevelReloader.Main.Name, LevelReloader.Main.Version,
        LevelReloader.Main.Author, LevelReloader.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]