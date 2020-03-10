﻿using RimWorld;
using RimWorld.Planet;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    public class BiomeWorker_Archipelago_TemperateSwamp : BiomeWorker
    {
        public BiomeWorker_Archipelago_TemperateSwamp() { }
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
            if (tile.temperature < -10f)
            {
                return -100f;
            }
            if (tile.rainfall < 600f)
            {
                return 0f;
            }
            if (tile.swampiness < 0.5f)
            {
                return 0f;
            }
            return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f + tile.swampiness * 3f;
        }
    }
}
