using Creek.Extensibility.Plugins;
using Paint.Contracts;

namespace Paint
{
    [PlugInApplication("Paint")]
    internal class PlugInManager : PlugInBasedApplication<IPaintPlugIn>, IPaintApplication
    {
        
    }
}
