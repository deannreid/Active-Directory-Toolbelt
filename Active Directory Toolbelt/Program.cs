/*
 * Active Directory Toolbelt
 * Developed by @ Dean Reid
 *
 * Class Name: Resources
 *
 * Class Information:
 *
 * Class handles quick references to make changes quicker.
 *
 * Program Version: 1.0
 * Code Version: 1.0
 *
 * Updates:
 * 05/11/2023 - Initial Code Development
 */

using Active_Directory_Toolbelt.handlers;
using Active_Directory_Toolbelt.ui;
using Active_Directory_Toolbelt.utils;
using Sentry;
using System.IO;
using static Active_Directory_Toolbelt.handlers.LogHandler;
using Application = System.Windows.Forms.Application;

namespace Active_Directory_Toolbelt
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            // {0BD8AA8F-22D1-4E08-984C-5617C5B56AA7}
            // Init the Sentry SDK
            SentrySdk.Init(o =>
            {
                // Tells which project in Sentry to send events to:
                o.Dsn = "https://56e3fd13e596310d4138515735b7d738@o97016.ingest.sentry.io/4506175501959168";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set TracesSampleRate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;

                // Configure WinForms to throw exceptions so Sentry can capture them.
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            });
            {
                if (Reference.DEBUG_MODE == true)
                {
                    if (!Directory.Exists(Reference.ADT_ROOT_LOC))
                    {
                        Directory.CreateDirectory(Reference.ADT_ROOT_LOC);
                        Directory.CreateDirectory(Reference.LOG_FILE_LOC);
                    }
                    LogHandler.ErrorLog(LogTarget.File, "Error Log - Log Handler Test");

                    //Load Visuals
                    LogHandler.Log(LogTarget.File, "Loading Visuals");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    //Make sure root dir exists before loading.
                    LogHandler.Log(LogTarget.File, "Debug Mode Enabled");
                    LogHandler.Log(LogTarget.File, "============================");
                    LogHandler.Log(LogTarget.File, "Program Starting");

                    //Load Checks Needed First
                    LogHandler.Log(LogTarget.File, "Program Pre-Run Checks");

                    var lh = new LocationHandler();

                    //If Load Checks Pass
                    if (LocationHandler.programRun == true)
                    {
                        LogHandler.Log(LogTarget.File, "Program Pre-Run Checks Completed");

                        //Load the final files
                        LogHandler.Log(LogTarget.File, "Loading Folders");

                        var fh = new FileHandler();

                        //Load Program
                        LogHandler.Log(LogTarget.File, "Program Run Checks: Successful - Starting Program");
                        Application.Run(new MainMenu());
                    }
                    else
                    {
                        if (System.Windows.Forms.Application.MessageLoop)
                        {
                            SentrySdk.CaptureMessage(" Program Run Checks: Failed - Access Denied - User Not Allowed Access.");
                            LogHandler.ErrorLog(LogTarget.File, "Program Run Checks: Failed - Access Denied.");
                            LogHandler.ErrorLog(LogTarget.EventLog, "Program Run Checks: Failed - Access Denied.");
                            System.Windows.Forms.Application.Exit();
                        }
                        else
                        {
                            SentrySdk.CaptureMessage(" Program Run Checks: Failed - Access Denied - User Not Allowed Access.");
                            LogHandler.ErrorLog(LogTarget.File, "Program Run Checks: Failed - Access Denied.");
                            LogHandler.ErrorLog(LogTarget.EventLog, "Program Run Checks: Failed - Access Denied.");
                            System.Environment.Exit(1);
                        }
                    }
                }
                else
                {
                    SentrySdk.CaptureMessage("");

                    if (!Directory.Exists(Reference.ADT_ROOT_LOC)) { Directory.CreateDirectory(Reference.ADT_ROOT_LOC); }
                    Console.WriteLine("Debug Mode Disabled");
                    Application.Run(new MainMenu());
                    var lh = new LocationHandler();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    var fh = new FileHandler();
                    if (LocationHandler.programRun == true)
                    {
                        //Ensure folders are created
                        var fh1 = new FileHandler();
                        //Load Program
                        Application.Run(new MainMenu());
                    }
                    else
                    {
                        if (System.Windows.Forms.Application.MessageLoop)
                        {
                            SentrySdk.CaptureMessage(" Program Run Checks: Failed - Access Denied - User Not Allowed Access.");
                            LogHandler.ErrorLog(LogTarget.File, "Program Run Checks: Failed - Access Denied from this system.");
                            LogHandler.ErrorLog(LogTarget.EventLog, "Program Run Checks: Failed - Access Denied from this system.");
                            System.Windows.Forms.Application.Exit();
                        }
                        else
                        {
                            SentrySdk.CaptureMessage(" Program Run Checks: Failed - Access Denied - User Not Allowed Access.");
                            LogHandler.ErrorLog(LogTarget.File, "Program Run Checks: Failed - Access Denied from this system.");
                            LogHandler.ErrorLog(LogTarget.EventLog, "Program Run Checks: Failed - Access Denied from this system.");
                            System.Environment.Exit(1);
                        }
                    }
                }
            }
        }
    }
}