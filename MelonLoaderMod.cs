using MelonLoader;
using StressLevelZero.Rig;
using UnityEngine;
using ModThatIsNotMod.BoneMenu;
using Colour = UnityEngine.Color;

namespace NoSprinting
{
    public static class BuildInfo
    {
        public const string Name = "NoSprinting"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Adi"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class NoSprinting : MelonMod
    {
        ControllerRig rig;
        public bool enabled = false;
        public override void OnApplicationStart()
        {
            var cat = MenuManager.CreateCategory("Sprinting", Colour.white);
            cat.CreateBoolElement("Enabled", Colour.white, enabled, delegate (bool value) { enabled = value; });
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName) => rig = Object.FindObjectOfType<ControllerRig>();
        public override void OnUpdate()
        {
            if (!enabled && rig != null && rig._jogToggle)
                rig._jogToggle = false;
        }
    }
}
