/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Schweiger Simon
 * Datum: 10.12.2006
 * Zeit: 17:10
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.IO;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;
using ICSharpCode.Core;
using Paint;
using AppLoadingMT;

namespace Startup
{
    public class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Splasher.Show();
            DoStartup(args);
        }

        static void DoStartup(string[] args)
        {
            LoggingService.Info("Application start");
            Assembly exe = typeof(Startup).Assembly;
            FileUtility.ApplicationRootPath = Path.GetDirectoryName(exe.Location);

            LoggingService.Info("Starting core services...");
            CoreStartup coreStartup = new CoreStartup("Paint");
            coreStartup.PropertiesName = "AppProperties";
            coreStartup.StartCoreServices();

            ResourceService.RegisterNeutralStrings(
                new ResourceManager("Startup.StringResources", exe));
            ResourceService.RegisterNeutralImages(
                new ResourceManager("Startup.ImageResources", exe));

            LoggingService.Info("Looking for AddIns...");
            // Searches for ".addin" files in the
            // application directory.
            coreStartup.AddAddInsFromDirectory(
                Path.Combine(FileUtility.ApplicationRootPath, "AddIns"));

            coreStartup.ConfigureExternalAddIns(
                Path.Combine(PropertyService.ConfigDirectory, "AddIns.xml"));

            coreStartup.ConfigureUserAddIns(
                Path.Combine(PropertyService.ConfigDirectory, "AddInInstallTemp"),
                Path.Combine(PropertyService.ConfigDirectory, "AddIns"));

            LoggingService.Info("Loading AddInTree...");
            // Now finally initialize the application.
            // This parses the ".addin" files and
            // creates the AddIn tree. It also
            // automatically runs the commands in
            // "/Workspace/Autostart"
            coreStartup.RunInitialization();

            LoggingService.Info("Initializing Workbench...");
            // Workbench is our class from the base
            // project, this method creates an instance
            // of the main form.
            Workbench.InitializeWorkbench();

            try
            {
                LoggingService.Info("Running application...");
                Application.Run(Workbench.Instance);
            }
            finally
            {
                try
                {
                    PropertyService.Save();
                }
                catch (Exception ex)
                {
                    MessageService.ShowError(ex, "Error storing properties");
                }
            }
            LoggingService.Info("Application shutdown");

            SingleInstanceController controller = new SingleInstanceController();
            controller.Run(args);
        }
    }
}