using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;

namespace CSSharpPluginTemplate
{
    [MinimumApiVersion(305)] // As of 3/16/2025
    public class CSSharpPluginTemplate : BasePlugin
    {
        public override string ModuleName => "PLUGIN_NAME";
        public override string ModuleVersion => "CHANGE_PLUGIN_VERSION";
        public override string ModuleAuthor => "CHANGE_PLUGIN_AUTHOR";
        public override string ModuleDescription => "CHANGE_PLUGIN_DESCRIPTION";

        public override void Load(bool hotReload)
        {
            // Load logic
        }

        public override void Unload(bool hotReload)
        {
            // Unload logic
        }
    }
}
