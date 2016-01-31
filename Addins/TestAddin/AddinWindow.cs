using System;
using Paint.Core.Commands;
using System.Windows.Forms;

namespace TestAddin
{
    public class AddinWindow : ReturnableCommand
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override object RunCommand() => new TextBox();
    }
}