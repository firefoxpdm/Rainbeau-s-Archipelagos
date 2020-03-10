﻿using Harmony;
using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using Verse;

namespace RA_Code {

	[StaticConstructorOnStartup]
	internal static class Archi_Initializer {
		static Archi_Initializer() {
			foreach (ThingDef current in DefDatabase<ThingDef>.AllDefsListForReading) {
				if (current.plant != null) {
					if (current.plant.wildBiomes != null) {
						for (int j = 0; j < current.plant.wildBiomes.Count; j++) {
							if (current.plant.wildBiomes[j].biome.defName == "AridShrubland") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("DesertArchipelago");
								newRecord2.biome = BiomeDef.Named("DesertArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
							if (current.plant.wildBiomes[j].biome.defName == "BorealForest") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("BorealArchipelago");
								newRecord2.biome = BiomeDef.Named("BorealArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
							if (current.plant.wildBiomes[j].biome.defName == "ColdBog") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("ColdBogArchipelago");
								newRecord2.biome = BiomeDef.Named("ColdBogArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
							if (current.plant.wildBiomes[j].biome.defName == "TemperateForest") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("TemperateArchipelago");
								newRecord2.biome = BiomeDef.Named("TemperateArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
							if (current.plant.wildBiomes[j].biome.defName == "TemperateSwamp") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("TemperateSwampArchipelago");
								newRecord2.biome = BiomeDef.Named("TemperateSwampArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
							if (current.plant.wildBiomes[j].biome.defName == "TropicalRainforest") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("TropicalArchipelago");
								newRecord2.biome = BiomeDef.Named("TropicalArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
							if (current.plant.wildBiomes[j].biome.defName == "TropicalSwamp") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("TropicalSwampArchipelago");
								newRecord2.biome = BiomeDef.Named("TropicalSwampArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
							if (current.plant.wildBiomes[j].biome.defName == "Tundra") {
								PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
								PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
								newRecord1.biome = BiomeDef.Named("TundraArchipelago");
								newRecord2.biome = BiomeDef.Named("TundraArchipelago_Fresh");
								newRecord1.commonality = current.plant.wildBiomes[j].commonality;
								newRecord2.commonality = current.plant.wildBiomes[j].commonality;
								current.plant.wildBiomes.Add(newRecord1);
								current.plant.wildBiomes.Add(newRecord2);
							}
						}
					}
				}
			}
			foreach (PawnKindDef current in DefDatabase<PawnKindDef>.AllDefs) {
				if (current.RaceProps.wildBiomes != null && current.defName != "Cobra") {
					for (int j = 0; j < current.RaceProps.wildBiomes.Count; j++) {
						if (current.RaceProps.wildBiomes[j].biome.defName == "AridShrubland") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("DesertArchipelago");
							newRecord2.biome = BiomeDef.Named("DesertArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
						if (current.RaceProps.wildBiomes[j].biome.defName == "BorealForest") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("BorealArchipelago");
							newRecord2.biome = BiomeDef.Named("BorealArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
						if (current.RaceProps.wildBiomes[j].biome.defName == "ColdBog") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("ColdBogArchipelago");
							newRecord2.biome = BiomeDef.Named("ColdBogArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
						if (current.RaceProps.wildBiomes[j].biome.defName == "TemperateForest") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("TemperateArchipelago");
							newRecord2.biome = BiomeDef.Named("TemperateArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
						if (current.RaceProps.wildBiomes[j].biome.defName == "TemperateSwamp") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("TemperateSwampArchipelago");
							newRecord2.biome = BiomeDef.Named("TemperateSwampArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
						if (current.RaceProps.wildBiomes[j].biome.defName == "TropicalRainforest") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("TropicalArchipelago");
							newRecord2.biome = BiomeDef.Named("TropicalArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
						if (current.RaceProps.wildBiomes[j].biome.defName == "TropicalSwamp") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("TropicalSwampArchipelago");
							newRecord2.biome = BiomeDef.Named("TropicalSwampArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
						if (current.RaceProps.wildBiomes[j].biome.defName == "Tundra") {
							AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
							AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
							newRecord1.biome = BiomeDef.Named("TundraArchipelago");
							newRecord2.biome = BiomeDef.Named("TundraArchipelago_Fresh");
							newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
							newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
							current.RaceProps.wildBiomes.Add(newRecord1);
							current.RaceProps.wildBiomes.Add(newRecord2);
						}
					}
				}
			}
		}
	}

	public class Controller : Mod {
		public static Settings Settings;
		public override string SettingsCategory() { return "RFA.Archipelagos".Translate(); }
		public override void DoSettingsWindowContents(Rect canvas) { Settings.DoWindowContents(canvas); }
		public Controller(ModContentPack content) : base(content) {
			HarmonyInstance harmony = HarmonyInstance.Create("net.rainbeau.rimworld.mod.archipelagos");
			harmony.PatchAll( Assembly.GetExecutingAssembly() );
			Settings = GetSettings<Settings>();
		}
	}

	public class Settings : ModSettings {
		public float waterLevel = 2.5f;
		public void DoWindowContents(Rect canvas) {
			Listing_Standard list = new Listing_Standard();
			list.ColumnWidth = canvas.width;
			list.Begin(canvas);
			list.Gap();
			if (waterLevel < 1) { list.Label("RFA.waterLevel".Translate()+"  "+"RFA.WaterVeryLow".Translate()); }
			else if (waterLevel < 2) { list.Label("RFA.waterLevel".Translate()+"  "+"RFA.WaterLow".Translate()); }
			else if (waterLevel < 3) {
				GUI.contentColor = Color.yellow;
				list.Label("RFA.waterLevel".Translate()+"  "+"RFA.WaterNormal".Translate());
				GUI.contentColor = Color.white;
			}
			else if (waterLevel < 4) { list.Label("RFA.waterLevel".Translate()+"  "+"RFA.WaterHigh".Translate()); }
			else { list.Label("RFA.waterLevel".Translate()+"  "+"RFA.WaterVeryHigh".Translate()); }
			waterLevel = list.Slider(waterLevel, 0, 5);
			list.End();
		}
		public override void ExposeData() {
			base.ExposeData();
			Scribe_Values.Look(ref waterLevel, "waterLevel", 2.5f);
		}
	}
	
	public class BiomeWorker_Archipelago_Boreal : BiomeWorker {
		public BiomeWorker_Archipelago_Boreal() { }
		public override float GetScore(Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < -10f || tile.temperature > 15f) {
				return -100f;
			}
			if (tile.rainfall < 600f) {
				return 0f;
			}
			return 15f;
		}
	}

	public class BiomeWorker_Archipelago_ColdBog : BiomeWorker {
		public BiomeWorker_Archipelago_ColdBog() { }
		public override float GetScore(Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < -10f || tile.temperature > 15f) {
				return -100f;
			}
			if (tile.swampiness < 0.5f) {
				return 0f;
			}
			return -tile.temperature + 13f + tile.swampiness * 8f;
		}
	}

	public class BiomeWorker_Archipelago_Desert : BiomeWorker {
		public BiomeWorker_Archipelago_Desert() { }
		public override float GetScore(Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < -10f) {
				return -100f;
			}
			if (tile.rainfall >= 2000f) {
				return 0f;
			}
			if (tile.rainfall < 600f) {
				return tile.temperature + 0.0001f;
			}
			return 22.5f + (tile.temperature - 20f) * 2.2f + (tile.rainfall - 600f) / 100f;
		}
	}

	public class BiomeWorker_Archipelago_Temperate : BiomeWorker {
		public BiomeWorker_Archipelago_Temperate() { }
		public override float GetScore(Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < -10f) {
				return -100f;
			}
			if (tile.rainfall < 600f) {
				return 0f;
			}
			return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f;
		}
	}

	public class BiomeWorker_Archipelago_TemperateSwamp : BiomeWorker {
		public BiomeWorker_Archipelago_TemperateSwamp() { }
		public override float GetScore(Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < -10f) {
				return -100f;
			}
			if (tile.rainfall < 600f) {
				return 0f;
			}
			if (tile.swampiness < 0.5f) {
				return 0f;
			}
			return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f + tile.swampiness * 3f;
		}
	}

	public class BiomeWorker_Archipelago_Tropical : BiomeWorker {
		public BiomeWorker_Archipelago_Tropical() { }
		public override float GetScore(Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < 15f) {
				return -100f;
			}
			if (tile.rainfall < 2000f) {
				return 0f;
			}
			return 28f + (tile.temperature - 20f) * 1.5f + (tile.rainfall - 600f) / 165f;
		}
	}

	public class BiomeWorker_Archipelago_TropicalSwamp : BiomeWorker {
		public BiomeWorker_Archipelago_TropicalSwamp() { }
		public override float GetScore(Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < 15f) {
				return -100f;
			}
			if (tile.rainfall < 2000f) {
				return 0f;
			}
			if (tile.swampiness < 0.5f) {
				return 0f;
			}
			return 28f + (tile.temperature - 20f) * 1.5f + (tile.rainfall - 600f) / 165f + tile.swampiness * 3f;
		}
	}

	public class BiomeWorker_Archipelago_Tundra : BiomeWorker {
		public BiomeWorker_Archipelago_Tundra() { }
		public override float GetScore (Tile tile, int tileID) {
			if (!tile.WaterCovered) {
				return -100f;
			}
			if (tile.elevation < -99) {
				return -100f;
			}
			if (tile.temperature < -21f) {
				return -100f;
			}
			return -tile.temperature;
		}
	}

	public class BiomeWorker_Archipelago_Fresh : BiomeWorker {
		public BiomeWorker_Archipelago_Fresh() { }
		public override float GetScore (Tile tile, int tileID) {
			return -100f;
		}
	}

	[HarmonyPatch(typeof(World), "CoastDirectionAt", null)]
	public static class World_CoastDirectionAt {
		public static bool Prefix(int tileID, ref Rot4 __result, ref World __instance) {
			var world = Traverse.Create(__instance);
			WorldGrid worldGrid = world.Field("grid").GetValue<WorldGrid>();
			if (worldGrid[tileID].biome.defName.Contains("Archipelago")) {
				__result = Rot4.Invalid;
				return false;
			}
			return true;
		}
	}
	
	[HarmonyPatch(typeof(WorldGenStep_Terrain), "GenerateTileFor", null)]
	public static class WorldGenStep_Terrain_GenerateTileFor {
		public static void Postfix(int tileID, ref Tile __result) {
			if (__result.biome.defName.Contains("Archipelago")) {
				if (Rand.Value > 0.03f) {
					__result.biome = BiomeDef.Named("Ocean");
				}
				else {
					__result.elevation += 100;
					if (Rand.Value < 0.33f) {
						__result.hilliness = Hilliness.SmallHills;
						if (Rand.Value < 0.25f) {
							__result.hilliness = Hilliness.LargeHills;
						}
					}
				}
			}
		}
	}

	[HarmonyPatch(typeof(WorldGenStep_Lakes), "GenerateLakes", null)]
	public static class WorldGenStep_Lakes_GenerateLakes {
		private static bool Prefix() {
			WorldGrid worldGrid = Find.WorldGrid;
			bool[] flagArray = new bool[worldGrid.TilesCount];
			List<int> nums = new List<int>();
			for (int i = 0; i < worldGrid.TilesCount; i++) {
				if (!flagArray[i]) {
					if (worldGrid[i].biome == BiomeDefOf.Ocean || (worldGrid[i].biome.defName != null && worldGrid[i].biome.defName.Contains("Archipelago"))) {
						Find.WorldFloodFiller.FloodFill(i, (int tid) => (worldGrid[tid].biome == BiomeDefOf.Ocean || (worldGrid[tid].biome.defName != null && worldGrid[tid].biome.defName.Contains("Archipelago"))), (int tid) => {
							nums.Add(tid);
							flagArray[tid] = true;
						}, 2147483647);
						if (nums.Count <= 180) {
							for (int j = 0; j < nums.Count; j++) {
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
		
	[HarmonyPatch(typeof(GenStep_Terrain), "TerrainFrom", null)]
	public static class GenStep_Terrain_TerrainFrom {
		private static bool Prefix(IntVec3 c, Map map, float elevation, float fertility, ref TerrainDef __result) {
			if (map.Biome.defName.Contains("Archipelago")) {
				float adjustment = 0.0f;
				if (Controller.Settings.waterLevel < 1) { adjustment = -0.1f; }
				else if (Controller.Settings.waterLevel < 2) { adjustment = -0.05f; }
				else if (Controller.Settings.waterLevel < 3) { }
				else if (Controller.Settings.waterLevel < 4) { adjustment = 0.05f; }
				else { adjustment = 0.1f; }
				bool lakeIsles = false;
				if (map.Biome.defName.Contains("_Fresh")) { lakeIsles = true; }
				if (elevation < 0.75f) {
					Building edifice = c.GetEdifice(map);
					if (edifice != null) { edifice.Destroy(DestroyMode.Vanish); }
					map.roofGrid.SetRoof(c, null);
					for (int i = -1; i < 2; i++) {
						for (int j = -1; j < 2; j++) {
							int x = c.x + i;
							int z = c.z + j;
							if (x >= 0 && z >= 0 && x < map.Size.x && z < map.Size.z) {
								IntVec3 newSpot = new IntVec3(x, 0, z);
								if (map.roofGrid.RoofAt(newSpot) != null) {
									if (map.roofGrid.RoofAt(newSpot).isThickRoof) {
										map.roofGrid.SetRoof(newSpot, RoofDefOf.RoofRockThin);
									}
									else {
										if ((i == 0 && j != 0) || (i != 0 && j == 0)) {
											if (Rand.Value < 0.33) {
												map.roofGrid.SetRoof(newSpot, null);
											}
										}
									}
								}
							}
						}
					}
				}
				if (elevation > 0.65f && elevation <= 0.69f) {
					__result = TerrainDefOf.Gravel;
					return false;
				}
				if (elevation > 0.69f & elevation < 0.71f) {
					__result = TerrainDefOf.Gravel;
					return false;
				}
				if (elevation >= 0.71f) {
					__result = GenStep_RocksFromGrid.RockDefAt(c).building.naturalTerrain;
					return false;
				}
				TerrainDef deepWater = TerrainDefOf.WaterOceanDeep;
				TerrainDef shallowWater = TerrainDefOf.WaterOceanShallow;
				if (lakeIsles.Equals(true)) {
					deepWater = TerrainDefOf.WaterDeep;
					shallowWater = TerrainDefOf.WaterShallow;
				}
				if (elevation < 0.35f+adjustment) {
					__result = deepWater;
					return false;
				}
				if (elevation < 0.45f+adjustment) {
					__result = shallowWater;
					return false;
				}
				TerrainDef borderTerrainL = TerrainDefOf.Sand;
				TerrainDef borderTerrainH = TerrainDefOf.Sand;
				if (lakeIsles.Equals(true)) {
					if (map.Biome.defName.Contains("Boreal") || map.Biome.defName.Contains("Tundra")) {
						borderTerrainL = TerrainDef.Named("Mud");
						borderTerrainH = TerrainDef.Named("MossyTerrain");
					}
					else if (map.Biome.defName.Contains("ColdBog") || map.Biome.defName.Contains("Swamp")) {
						borderTerrainL = TerrainDef.Named("Marsh");
						borderTerrainH = TerrainDef.Named("MarshyTerrain");
					}
					else if (map.Biome.defName.Contains("Temperate") || map.Biome.defName.Contains("Tropical")) {
						borderTerrainL = TerrainDef.Named("Mud");
						borderTerrainH = TerrainDef.Named("SoilRich");
					}
				}
				if (elevation < 0.47f+adjustment) {
					__result = borderTerrainL;
					return false;
				}
				if (elevation < 0.50f+adjustment) {
					__result = borderTerrainH;
					return false;
				}
				TerrainDef terrainDef = TerrainThreshold.TerrainAtValue(map.Biome.terrainsByFertility, fertility);
				if (terrainDef != null) {
					__result = terrainDef;
					return false;
				}
				__result = borderTerrainH;
				return false;
			}
			return true;
		}
	}
	
}
