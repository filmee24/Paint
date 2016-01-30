using AppLoadingMT;
using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace Paint
{
    static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Splasher.Show();
            DoStartup(args);
        } 

        static void DoStartup(string[] args)
        {
            //	do whatever you need to do
            SingleInstanceController controller = new SingleInstanceController();
            controller.Run(args);

            Splasher.Status = "Loading...";
        }
    }

    public class SingleInstanceController : WindowsFormsApplicationBase
    {
        public SingleInstanceController()
        {
            IsSingleInstance = true;

            StartupNextInstance += this_StartupNextInstance;
        }

        void this_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            var form = MainForm as MainWindow;
            
            form.OpenImage(e.CommandLine[0]);

            Splasher.Close();
        }

        protected override void OnCreateMainForm()
        {
            MainForm = new MainWindow();
            Splasher.Close();
        }
    }
}