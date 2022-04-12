using Exiled.API.Interfaces;

namespace FlashProfiler
{
    public class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}