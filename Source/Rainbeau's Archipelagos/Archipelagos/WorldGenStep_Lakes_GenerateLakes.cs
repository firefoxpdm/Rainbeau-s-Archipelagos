using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using System.Collections.Generic;
using Verse;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    [HarmonyPatch(typeof(WorldGenStep_Lakes), "GenerateLakes", null)]
    public static class WorldGenStep_Lakes_GenerateLakes
    {
        private static bool Prefix()
        {
            WorldGrid worldGrid = Find.WorldGrid;
            bool[] flagArray = new bool[worldGrid.TilesCount];
            List<int> nums = new List<int>();
            for (int i = 0; i < worldGrid.TilesCount; i++)
            {
                if (!flagArray[i])
                {
                    if (worldGrid[i].biome == BiomeDefOf.Ocean || (worldGrid[i].biome.defName != null && worldGrid[i].biome.defName.Contains("Archipelago")))
                    {
                        Find.WorldFloodFiller.FloodFill(i, (int tid) => (worldGrid[tid].biome == BiomeDefOf.Ocean || (worldGrid[tid].biome.defName != null && worldGrid[tid].biome.defName.Contains("Archipelago"))), (int tid) => {
                            nums.Add(tid);
                            flagArray[tid] = true;
                        }, 2147483647);
                        if (nums.Count <= 180)
                        {
                            for (int j = 0; j < nums.Count; j++)
                            {
                                if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "BorealArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("BorealArchipelago_Fresh"); }
                                else if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "ColdBogArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("ColdBogArchipelago_Fresh"); }
                                else if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "DesertArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("DesertArchipelago_Fresh"); }
                                else if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "TemperateArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("TemperateArchipelago_Fresh"); }
                                else if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "TemperateSwampArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("TemperateSwampArchipelago_Fresh"); }
                                else if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "TropicalArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("TropicalArchipelago_Fresh"); }
                                else if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "TropicalSwampArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("TropicalSwampArchipelago_Fresh"); }
                                else if (worldGrid[nums[j]].biome.defName != null && worldGrid[nums[j]].biome.defName == "TundraArchipelago") { worldGrid[nums[j]].biome = BiomeDef.Named("TundraArchipelago_Fresh"); }
                                else { worldGrid[nums[j]].biome = BiomeDefOf.Lake; }
                            }
                        }
                        nums.Clear();
                    }
                }
            }
            return false;
        }
    }
}
