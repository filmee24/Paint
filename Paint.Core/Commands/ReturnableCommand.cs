using ICSharpCode.Core;

namespace Paint.Core.Commands
{
    public abstract class ReturnableCommand : AbstractCommand
    {
        public abstract object RunCommand();
    }
}