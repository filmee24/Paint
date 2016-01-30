using AppLoadingMT;
using Microsoft.VisualBasic.ApplicationServices;
using Paint.Core;
using System;
using System.IO;
using System.Windows.Forms;

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
            SingleInstanceController controller = new SingleInstanceController();
            controller.Run(args);

            ServiceLocator.Add(new PlugInManager());
            var pm = ServiceLocator.Get<PlugInManager>();

            pm.PlugInFolder = Application.StartupPath + "\\" + "Plugins";
            if(Directory.Exists(pm.PlugInFolder))
            {
                pm.LoadPlugIns();
            }
            else
            {
                Directory.CreateDirectory(pm.PlugInFolder);
            }

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