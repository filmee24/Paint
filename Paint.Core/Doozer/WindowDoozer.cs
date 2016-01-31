using System.Collections;
using ICSharpCode.Core;
using Paint.Core.Models;
using Paint.Core.Commands;
using System.Windows.Forms;

namespace Paint.Core.Doozer
{
    public class WindowDoozer : IDoozer
    {
        public bool HandleConditions => false;

        public object BuildItem(object caller, Codon codon, ArrayList subItems)
        {
            return new Window {
                Title = codon.Properties["title"],
                DockPosition = codon.Properties["position"],
                ContainerControl = (codon.AddIn.CreateObject(codon.Properties["class"]) as ReturnableCommand).RunCommand() as Control
            };
        }
    }
}