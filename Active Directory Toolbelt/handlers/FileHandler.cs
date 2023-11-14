using Active_Directory_Toolbelt.utils;
using System.Diagnostics;
using System.IO;
using static Active_Directory_Toolbelt.handlers.LogHandler;

/*
* Active Directory Toolbelt 
* Developed by @ Dean Reid
*
* Class Name: FileHandler
*
* Class Information:
*
* Class handles where files/folders are located and creates them if necessary
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
    public partial class FileHandler
    {
        // public string[] partnerNames = new string[7] { "Aviva", "Barclays", "FD", "HSBC", "MAS", "Santander", "TSB" };
        public FileHandler()
        {
            LogHandler.Log(LogTarget.File, "Checking Directory Structure");

            // Check if the config file exists - if it does then load it if not then create
        }

        public void CheckDirStructure()
        {
            if (!Directory.Exists(Reference.ADT_ROOT_LOC))
            {
                CreateDirStructure();
                LogHandler.Log(LogTarget.File, "Eyyy Mate, I Canny find the folder ye need.");
                LogHandler.Log(LogTarget.File, "Let me just create it fur ye.");
            }
            else
            {
                Directory.CreateDirectory(Reference.ADT_ROOT_LOC);
                CreateDirStructure();
                LogHandler.Log(LogTarget.File, "Eyyy Mate, I found yer files.");
            }
        }

        public void CreateDirStructure()
        {
            string[] partnerNames = new string[7] { "Aviva", "Barclays", "FD", "HSBC", "MAS", "Santander", "TSB" };

            // Check UAC Permissions

            using (Process process = new Process())
            {
            }

            Directory.CreateDirectory(Reference.ADT_ROOT_LOC + "\\policybooks");
            //Directory.CreateDirectory(Reference.CONFIG_FILE_DRIVE);
            Directory.CreateDirectory(Reference.LOG_FILE_LOC);
            foreach (string ptrName in partnerNames)
            {
                if (!Directory.Exists(Reference.ADT_ROOT_LOC + ptrName))
                {
                    //ADD UAC STUFF STILL
                    LogHandler.Log(LogTarget.File, "-  " + ptrName + " folder not found - Checking UAC Permissions");
                    Directory.CreateDirectory(Reference.ADT_ROOT_LOC + ptrName);
                    LogHandler.Log(LogTarget.File, "-      " + ptrName + " UAC Permission Ok - folder created");
                    // DownloadHandler not required at this time.
                    // DownloadHandler dh = new DownloadHandler(ptrName);
                }
                else
                {
                    Directory.CreateDirectory(Reference.ADT_ROOT_LOC + ptrName);

                    //Still need to check if files in the folder are still available and readable - if not then download the damaged file(s)
                    LogHandler.Log(LogTarget.File, "-      " + ptrName + " folder located");
                }
            }
        }

        public void ResetDirStructure()
        {
            LogHandler.Log(LogTarget.File, "Somethings just no right. Let me reset all the stuff that needs reset");
            DeleteDirStructure();
            if (Directory.Exists(Reference.ADT_ROOT_LOC))
            {
                LogHandler.Log(LogTarget.File, "Somethings just no right. It winny let me delete the stuff. ");
                LogHandler.Log(LogTarget.File, "You'll need to dae it yersel.");
            }
        }

        public void DeleteDirStructure()
        {
            LogHandler.Log(LogTarget.File, "Deleting those directories. because I can. ^__^");
            if (Directory.Exists(Reference.ADT_ROOT_LOC))
            {
                Directory.Delete(Reference.ADT_ROOT_LOC, true);
            }
        }

        public void UpdateDirStructure()
        {
            Console.WriteLine("Updating Directory Structure");
            Console.WriteLine("This should only take 1 hour. Don't worry, Be happy.");
            CreateDirStructure();
        }

        public void ForceUpdateDirStructure()
        {
            LogHandler.Log(LogTarget.File, "An Admin has forced an update.");
            DeleteDirStructure();
            Console.WriteLine("Updating Directory Structure");
            Console.WriteLine("This should only take 1 hour. Don't worry, Be happy.");
            CreateDirStructure();
        }

        public void CheckFiles()
        {
            throw new NotSupportedException();
        }
    }
}