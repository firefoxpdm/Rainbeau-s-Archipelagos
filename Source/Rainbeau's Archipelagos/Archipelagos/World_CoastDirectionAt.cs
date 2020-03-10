using HarmonyLib;
using RimWorld.Planet;
using Verse;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    [HarmonyPatch(typeof(World), "CoastDirectionAt", null)]
    public static class World_CoastDirectionAt
    {
        public static bool Prefix(int tileID, ref Rot4 __result, ref World __instance)
        {
            var world = Traverse.Create(__instance);
            WorldGrid worldGrid = world.Field("grid").GetValue<WorldGrid>();
            if (worldGrid[tileID].biome.defName.Contains("Archipelago"))
            {
                __result = Rot4.Invalid;
                return false;
            }
            return true;
        }
    }
}
