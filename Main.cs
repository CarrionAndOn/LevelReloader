using MelonLoader;
using SLZ.Marrow.SceneStreaming;
using UnityEngine;

namespace LevelReloader
{
    public class Main : MelonMod
    {
        internal const string Name = "Level Reloader"; // Required
        internal const string Description = "Reloads the level if you hit R."; // Required
        internal const string Author = "CarrionAndOn"; // Required
        internal const string Company = "Weather Electric"; // Set as null if blank
        internal const string Version = "1.0.0"; // Required
        internal const string DownloadLink = "null"; // Set as null if blank
        
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneStreamer.Reload();
            }
        }
    }
}