using System;
using Paint.Core.Commands;
using System.Windows.Forms;
using ICSharpCode.Core;

namespace TestAddin
{
    public class AddinWindow : ReturnableCommand
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override object RunCommand()
        {
            var btn = new Button();
            var container = new Panel();

            btn.Text = "Klick Mich!!";
            btn.Dock = DockStyle.Top;
            btn.Click += (s, e) =>
            {
                if(MessageService.AskQuestion("Are your Sure?"))
                {
                    var lbl = new Label();
                    lbl.Text = "I´m Legend";
                    lbl.Dock = DockStyle.Bottom;

                    container.Controls.Add(lbl);
                }
            };

            container.Controls.Add(btn);

            return container;
        }
    }
}