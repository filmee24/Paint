using AppLoadingMT;
using Microsoft.VisualBasic.ApplicationServices;

namespace Paint
{
    public class SingleInstanceController : WindowsFormsApplicationBase
    {
        public SingleInstanceController()
        {
            IsSingleInstance = true;

            StartupNextInstance += this_StartupNextInstance;
        }

        void this_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            var form = MainForm as Workbench;

            form.OpenImage(e.CommandLine[0]);

            Splasher.Close();
        }

        protected override void OnCreateMainForm()
        {
            MainForm = new Workbench();
            Splasher.Close();
        }
    }
}