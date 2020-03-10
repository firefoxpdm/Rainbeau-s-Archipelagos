using RimWorld;
using Verse;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    [StaticConstructorOnStartup]
    internal static class Archi_Initializer
    {
        static Archi_Initializer()
        {
            foreach (ThingDef current in DefDatabase<ThingDef>.AllDefsListForReading)
            {
                if (current.plant != null)
                {
                    if (current.plant.wildBiomes != null)
                    {
                        for (int j = 0; j < current.plant.wildBiomes.Count; j++)
                        {
                            if (current.plant.wildBiomes[j].biome.defName == "AridShrubland")
                            {
                                PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
                                PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
                                newRecord1.biome = BiomeDef.Named("DesertArchipelago");
                                newRecord2.biome = BiomeDef.Named("DesertArchipelago_Fresh");
                                newRecord1.commonality = current.plant.wildBiomes[j].commonality;
                                newRecord2.commonality = current.plant.wildBiomes[j].commonality;
                                current.plant.wildBiomes.Add(newRecord1);
                                current.plant.wildBiomes.Add(newRecord2);
                            }
                            if (current.plant.wildBiomes[j].biome.defName == "BorealForest")
                            {
                                PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
                                PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
                                newRecord1.biome = BiomeDef.Named("BorealArchipelago");
                                newRecord2.biome = BiomeDef.Named("BorealArchipelago_Fresh");
                                newRecord1.commonality = current.plant.wildBiomes[j].commonality;
                                newRecord2.commonality = current.plant.wildBiomes[j].commonality;
                                current.plant.wildBiomes.Add(newRecord1);
                                current.plant.wildBiomes.Add(newRecord2);
                            }
                            if (current.plant.wildBiomes[j].biome.defName == "ColdBog")
                            {
                                PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
                                PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
                                newRecord1.biome = BiomeDef.Named("ColdBogArchipelago");
                                newRecord2.biome = BiomeDef.Named("ColdBogArchipelago_Fresh");
                                newRecord1.commonality = current.plant.wildBiomes[j].commonality;
                                newRecord2.commonality = current.plant.wildBiomes[j].commonality;
                                current.plant.wildBiomes.Add(newRecord1);
                                current.plant.wildBiomes.Add(newRecord2);
                            }
                            if (current.plant.wildBiomes[j].biome.defName == "TemperateForest")
                            {
                                PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
                                PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
                                newRecord1.biome = BiomeDef.Named("TemperateArchipelago");
                                newRecord2.biome = BiomeDef.Named("TemperateArchipelago_Fresh");
                                newRecord1.commonality = current.plant.wildBiomes[j].commonality;
                                newRecord2.commonality = current.plant.wildBiomes[j].commonality;
                                current.plant.wildBiomes.Add(newRecord1);
                                current.plant.wildBiomes.Add(newRecord2);
                            }
                            if (current.plant.wildBiomes[j].biome.defName == "TemperateSwamp")
                            {
                                PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
                                PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
                                newRecord1.biome = BiomeDef.Named("TemperateSwampArchipelago");
                                newRecord2.biome = BiomeDef.Named("TemperateSwampArchipelago_Fresh");
                                newRecord1.commonality = current.plant.wildBiomes[j].commonality;
                                newRecord2.commonality = current.plant.wildBiomes[j].commonality;
                                current.plant.wildBiomes.Add(newRecord1);
                                current.plant.wildBiomes.Add(newRecord2);
                            }
                            if (current.plant.wildBiomes[j].biome.defName == "TropicalRainforest")
                            {
                                PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
                                PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
                                newRecord1.biome = BiomeDef.Named("TropicalArchipelago");
                                newRecord2.biome = BiomeDef.Named("TropicalArchipelago_Fresh");
                                newRecord1.commonality = current.plant.wildBiomes[j].commonality;
                                newRecord2.commonality = current.plant.wildBiomes[j].commonality;
                                current.plant.wildBiomes.Add(newRecord1);
                                current.plant.wildBiomes.Add(newRecord2);
                            }
                            if (current.plant.wildBiomes[j].biome.defName == "TropicalSwamp")
                            {
                                PlantBiomeRecord newRecord1 = new PlantBiomeRecord();
                                PlantBiomeRecord newRecord2 = new PlantBiomeRecord();
                                newRecord1.biome = BiomeDef.Named("TropicalSwampArchipelago");
                                newRecord2.biome = BiomeDef.Named("TropicalSwampArchipelago_Fresh");
                                newRecord1.commonality = current.plant.wildBiomes[j].commonality;
                                newRecord2.commonality = current.plant.wildBiomes[j].commonality;
                                current.plant.wildBiomes.Add(newRecord1);
                                current.plant.wildBiomes.Add(newRecord2);
                            }
                            if (current.plant.wildBiomes[j].biome.defName == "Tundra")
                            {
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
            foreach (PawnKindDef current in DefDatabase<PawnKindDef>.AllDefs)
            {
                if (current.RaceProps.wildBiomes != null && current.defName != "Cobra")
                {
                    for (int j = 0; j < current.RaceProps.wildBiomes.Count; j++)
                    {
                        if (current.RaceProps.wildBiomes[j].biome.defName == "AridShrubland")
                        {
                            AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
                            AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
                            newRecord1.biome = BiomeDef.Named("DesertArchipelago");
                            newRecord2.biome = BiomeDef.Named("DesertArchipelago_Fresh");
                            newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
                            newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
                            current.RaceProps.wildBiomes.Add(newRecord1);
                            current.RaceProps.wildBiomes.Add(newRecord2);
                        }
                        if (current.RaceProps.wildBiomes[j].biome.defName == "BorealForest")
                        {
                            AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
                            AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
                            newRecord1.biome = BiomeDef.Named("BorealArchipelago");
                            newRecord2.biome = BiomeDef.Named("BorealArchipelago_Fresh");
                            newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
                            newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
                            current.RaceProps.wildBiomes.Add(newRecord1);
                            current.RaceProps.wildBiomes.Add(newRecord2);
                        }
                        if (current.RaceProps.wildBiomes[j].biome.defName == "ColdBog")
                        {
                            AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
                            AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
                            newRecord1.biome = BiomeDef.Named("ColdBogArchipelago");
                            newRecord2.biome = BiomeDef.Named("ColdBogArchipelago_Fresh");
                            newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
                            newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
                            current.RaceProps.wildBiomes.Add(newRecord1);
                            current.RaceProps.wildBiomes.Add(newRecord2);
                        }
                        if (current.RaceProps.wildBiomes[j].biome.defName == "TemperateForest")
                        {
                            AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
                            AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
                            newRecord1.biome = BiomeDef.Named("TemperateArchipelago");
                            newRecord2.biome = BiomeDef.Named("TemperateArchipelago_Fresh");
                            newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
                            newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
                            current.RaceProps.wildBiomes.Add(newRecord1);
                            current.RaceProps.wildBiomes.Add(newRecord2);
                        }
                        if (current.RaceProps.wildBiomes[j].biome.defName == "TemperateSwamp")
                        {
                            AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
                            AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
                            newRecord1.biome = BiomeDef.Named("TemperateSwampArchipelago");
                            newRecord2.biome = BiomeDef.Named("TemperateSwampArchipelago_Fresh");
                            newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
                            newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
                            current.RaceProps.wildBiomes.Add(newRecord1);
                            current.RaceProps.wildBiomes.Add(newRecord2);
                        }
                        if (current.RaceProps.wildBiomes[j].biome.defName == "TropicalRainforest")
                        {
                            AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
                            AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
                            newRecord1.biome = BiomeDef.Named("TropicalArchipelago");
                            newRecord2.biome = BiomeDef.Named("TropicalArchipelago_Fresh");
                            newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
                            newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
                            current.RaceProps.wildBiomes.Add(newRecord1);
                            current.RaceProps.wildBiomes.Add(newRecord2);
                        }
                        if (current.RaceProps.wildBiomes[j].biome.defName == "TropicalSwamp")
                        {
                            AnimalBiomeRecord newRecord1 = new AnimalBiomeRecord();
                            AnimalBiomeRecord newRecord2 = new AnimalBiomeRecord();
                            newRecord1.biome = BiomeDef.Named("TropicalSwampArchipelago");
                            newRecord2.biome = BiomeDef.Named("TropicalSwampArchipelago_Fresh");
                            newRecord1.commonality = current.RaceProps.wildBiomes[j].commonality;
                            newRecord2.commonality = current.RaceProps.wildBiomes[j].commonality;
                            current.RaceProps.wildBiomes.Add(newRecord1);
                            current.RaceProps.wildBiomes.Add(newRecord2);
                        }
                        if (current.RaceProps.wildBiomes[j].biome.defName == "Tundra")
                        {
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
}
