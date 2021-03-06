using System;
using Exiled.API.Features;
using HarmonyLib;

namespace FlashProfiler
{
    public class FlashProfiler : Plugin<PluginConfig>
    {
        public override string Name { get; } = "FlashProfiler";
        public override string Prefix { get; } = "flash_profiler";
        public override string Author { get; } = "Jesus-QC";
        public override Version Version { get; } = new Version(0, 0, 2);
        public override Version RequiredExiledVersion { get; } = new Version(5,0,0);

        private Harmony _harmony;

        public override void OnEnabled()
        {
            _harmony = new Harmony($"com.jesusqc.flash");
            _harmony.PatchAll();
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            _harmony.UnpatchAll(_harmony.Id);
            _harmony = null;
            
            base.OnDisabled();
        }
    }
}