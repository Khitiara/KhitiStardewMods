using Microsoft.Xna.Framework;
using StardewValley.Objects;

namespace BudgetTVFix;

internal static class Patches
{
    internal static bool GetScreenPosition_Prefix(TV __instance, ref Vector2 __result)
    {
        if ("(F)1466".Equals(__instance.QualifiedItemId, StringComparison.InvariantCultureIgnoreCase)) {
            __result = new Vector2(__instance.boundingBox.X + 24, __instance.boundingBox.Y - 64);
            return false;
        }

        return true;
    }
}