using BepInEx;
using BepInEx.Configuration;
using Jerald;
using System.Text;
[assembly: AutoRegister]
namespace GorillaEarmuffs
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<float> maxDistance;

        void Start()
        {
            maxDistance = Config.Bind("Audio", "MaxDistance", 4.5f, "Maximum distance before voices become completely inaudible.");
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
