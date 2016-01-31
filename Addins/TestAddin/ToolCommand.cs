using ICSharpCode.Core;

namespace TestAddin
{
    public class ToolCommand : AbstractCommand
    {
        public override void Run()
        {
            MessageService.ShowMessage("Hello from Addin");
        }
    }
}