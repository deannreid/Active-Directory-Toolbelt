using Active_Directory_Toolbelt.ui;
using Active_Directory_Toolbelt.utils;
using Sentry;
using System.Security.Principal;
using static Active_Directory_Toolbelt.handlers.LogHandler;
using MessageBox = System.Windows.Forms.MessageBox;

/*
 * Aviva Policy Book Deployment Tool V2
 * Developed by @ Dean Reid
 *
 * Class Name: LocationHandler
 *
 * Class Information:
 *
 * Class handles the location of the user. completed security checks and checks if user is allowed to access this program.
 *
 * Maybe be linked to RITA to ensure secure auditing of user access.
 *
 * Program Version: 1.0
 * Code Version: 2.0
 *
 * Updates:
 * 14/10/2021 - Initial Code Development
 *
 */

namespace Active_Directory_Toolbelt.handlers
{
    // pcode
    /*
     if (ProgramRun = Production Environment & Program Domain == AVIVAGROUP || AVIA) {
        // Program being run in-office so grab data from internal network
     } else if (ProgramRun = NonProduction + Debugging enabled) {
        // Program probably being run in Dev mode so allow access
    } else if (ProgramRun = NonProduction + Not in Debug Mode) {
     Disable Program Access as this should not be run
    }
    */

    public partial class LocationHandler
    {
        //set false for program run
        public static Boolean programRun = false;

        public LocationHandler()
        {
            var transaction = SentrySdk.StartTransaction(
                 "location-handler",
                 "location-handler-operation"
               );
            LogHandler.Log(LogTarget.File, "Program Run Checks: Loading");

            if (Reference.DOMAIN_ID == "AVIVAGROUP" && Reference.PRODUCTION_SERVER == true)
            {
                LogHandler.Log(LogTarget.File, "Program Run Checks: Running in production mode; Current Location: " + Reference.DOMAIN_ID);
                transaction.Finish();
                programRun = true;
            }
            else if (Reference.PRODUCTION_SERVER == false && Reference.DEBUG_MODE == true)
            {
                LogHandler.Log(LogTarget.File, "Program Run Checks: Running in development mode; Current Location: " + Reference.DOMAIN_ID);

                transaction.Finish();
                programRun = true;
            }
            else if (Reference.PRODUCTION_SERVER == true && Reference.DEBUG_MODE == false && Reference.DOMAIN_ID != "AVIVAGROUP")
            {
                DialogResult dr;
                LogHandler.ErrorLog(LogTarget.File, "Program Run Checks: Running in production mode; Current Location: " + Reference.DOMAIN_ID + " Not an acceptable location");
                dr = MessageBox.Show("Program Run Check", "Running in production mode. Current Location: " + Reference.DOMAIN_ID + " Not an acceptable location", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LogHandler.Log(LogTarget.File, Reference.ADT_ROOT_LOC);
                if (dr == DialogResult.OK)
                {
                    MainMenu sp = new MainMenu();
                    sp.ShowDialog();
                }
                LogHandler.ErrorLog(LogTarget.File, "File does not exist.");
                transaction.Finish();
                programRun = false;
            }
        }

        public static bool IsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

#pragma warning disable CS8602 // Dereference of a possibly null reference.

        private static bool IsElevated => WindowsIdentity.GetCurrent().Owner
                  .IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid);

#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}