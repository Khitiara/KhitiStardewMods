using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using StardewModdingAPI;
using StardewValley.Objects;

namespace BudgetTVFix;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
// ReSharper disable once ClassNeverInstantiated.Global
public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        Harmony harmony = new(ModManifest.UniqueID);
        harmony.Patch(original: AccessTools.Method(typeof(TV), nameof(TV.getScreenPosition)),
            prefix: new HarmonyMethod(typeof(Patches), nameof(Patches.GetScreenPosition_Prefix))
        );
    }
}