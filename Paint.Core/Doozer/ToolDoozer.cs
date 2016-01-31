using System.Collections;
using ICSharpCode.Core;

namespace Paint.Core.Doozer
{
    public class ToolDoozer : IDoozer
    {
        public bool HandleConditions => false;

        public object BuildItem(object caller, Codon codon, ArrayList subItems)
        {
            return new Tool {
                ToolTipText = codon.Properties["tooltiptext"],
                Command = codon.AddIn.CreateObject(codon.Properties["class"]) as AbstractCommand
            };
        }
    }
}