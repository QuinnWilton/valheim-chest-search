using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace ChestSearch
{
    [BepInPlugin("com.quinnwilton.plugins.chest_search", "Chest Search", "1.0.0")]
    public class ChestSearch : BaseUnityPlugin
    {
        private static Harmony harmonyInstance;
        void Awake()
        {
            harmonyInstance = Harmony.CreateAndPatchAll(
                Assembly.GetExecutingAssembly(),
                "com.quinnwilton.plugins.chest_search"
               );
        }

        void OnDestroy()
        {
            harmonyInstance.UnpatchSelf();
        }
    }
}
