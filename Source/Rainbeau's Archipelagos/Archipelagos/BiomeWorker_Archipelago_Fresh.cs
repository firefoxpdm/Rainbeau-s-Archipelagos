using RimWorld;
using RimWorld.Planet;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    public class BiomeWorker_Archipelago_Fresh : BiomeWorker
    {
        public BiomeWorker_Archipelago_Fresh() { }
        public override float GetScore(Tile tile, int tileID)
        {
            return -100f;
        }
    }
}
