using HarmonyLib;
using System.Reflection;
using UnityEngine;
using Verse;

namespace Rainbeau_s_Archipelagos.Archipelagos
{
    public class Controller : Mod
    {
        public static Settings Settings;
        public override string SettingsCategory() { return "RFA.Archipelagos".Translate(); }
        public override void DoSettingsWindowContents(Rect canvas) { Settings.DoWindowContents(canvas); }
        public Controller(ModContentPack content) : base(content)
        {
            Harmony harmony = new Harmony("net.rainbeau.rimworld.mod.archipelagos");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            Settings = GetSettings<Settings>();
        }
    }
}
