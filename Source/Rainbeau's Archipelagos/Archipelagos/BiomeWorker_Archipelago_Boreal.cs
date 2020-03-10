﻿using RimWorld;
using RimWorld.Planet;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    public class BiomeWorker_Archipelago_Boreal : BiomeWorker
    {
        public BiomeWorker_Archipelago_Boreal() { }
        public override float GetScore(Tile tile, int tileID)
        {
            if (!tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.elevation < -99)
            {
                return -100f;
            }
            if (tile.temperature < -10f || tile.temperature > 15f)
            {
                return -100f;
            }
            if (tile.rainfall < 600f)
            {
                return 0f;
            }
            return 15f;
        }
    }
}
