using UnityEngine;
using Verse;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    public class Settings : ModSettings
    {
        public float waterLevel = 2.5f;
        public void DoWindowContents(Rect canvas)
        {
            Listing_Standard list = new Listing_Standard();
            list.ColumnWidth = canvas.width;
            list.Begin(canvas);
            list.Gap();
            if (waterLevel < 1) { list.Label("RFA.waterLevel".Translate() + "  " + "RFA.WaterVeryLow".Translate()); }
            else if (waterLevel < 2) { list.Label("RFA.waterLevel".Translate() + "  " + "RFA.WaterLow".Translate()); }
            else if (waterLevel < 3)
            {
                GUI.contentColor = Color.yellow;
                list.Label("RFA.waterLevel".Translate() + "  " + "RFA.WaterNormal".Translate());
                GUI.contentColor = Color.white;
            }
            else if (waterLevel < 4) { list.Label("RFA.waterLevel".Translate() + "  " + "RFA.WaterHigh".Translate()); }
            else { list.Label("RFA.waterLevel".Translate() + "  " + "RFA.WaterVeryHigh".Translate()); }
            waterLevel = list.Slider(waterLevel, 0, 5);
            list.End();
        }
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref waterLevel, "waterLevel", 2.5f);
        }
    }
}
