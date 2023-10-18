
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Configuration;
using Comfort.Common;
using EFT;

namespace StanceRecoilBridge
{

    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("CombatStances", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("RecoilStandalone", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        void Update()
        {
            RecoilStandalone.Plugin.IsMounting = CombatStances.StanceController.IsMounting;
            RecoilStandalone.Plugin.MountingRecoilBonus = CombatStances.StanceController.MountingRecoilBonus;
            RecoilStandalone.Plugin.MountingSwayBonus = CombatStances.StanceController.MountingSwayBonus;
            RecoilStandalone.Plugin.BracingRecoilBonus = CombatStances.StanceController.BracingRecoilBonus;
            RecoilStandalone.Plugin.BracingSwayBonus = CombatStances.StanceController.BracingSwayBonus;
            CombatStances.Plugin.TotalHRecoil = RecoilStandalone.Plugin.TotalHRecoil;
            CombatStances.Plugin.TotalConvergence = RecoilStandalone.Plugin.TotalConvergence;
        }
    }
}

