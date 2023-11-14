using System.Reflection;

/*
 * Active Directory Toolbelt
 * Developed by @ Dean Reid
 *
 * Class Name: Reference
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

namespace Active_Directory_Toolbelt.utils
{
    internal class Reference
    {
        /**
         * Enable Debug Mode All The Lines...
         */
        public static Boolean DEBUG_MODE = true;

        /**
         * Training Wheels Mode
         */
        public static Boolean TRAINING_WHEELS = true;

        /**
         * Enable Dark Mode - Everyone has one of these nowadays - I Like it. The
         * Dark Side of the Force is with you.
         */
        public static Boolean DARK_MODE = true;

        //public UIDarkMode =
        public static String UI_COLOUR = "Green";

        public String UI_CODE = "MetroColorStyle." + UI_COLOUR;

        /*
         * Get ID Information - Enables Tracking and Auditing.
         */

        public static String COMPUTER_ID = Environment.MachineName.ToString();
        public static String USER_ID = Environment.UserName.ToString();
        public static String USER_NM = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public static String DOMAIN_ID = "XHSTCLOUD.GB";

        /**
         * Is the application setup for production
         * 	if true then connect to external db
         * 	if false then connect locally
         */
        public static Boolean PRODUCTION_SERVER = false;
        public static String PRODUCTION_SERVER_HN = "Cosmo DS";

        /**
           * Set Configuration Info.
           */

        //Local FS
        public static String ADT_ROOT_LOC = @"C:\\Users\" + USER_ID + @"\AppData\Local\ActiveDirectoryToolbelt";

        public static String CONFIG_FILE_NAME = ADT_ROOT_LOC + @"\config.cfg";

        /**
          * Log file locations
          */
        public static String LOG_FILE_LOC = @"C:\Users\" + USER_ID + @"\AppData\Local\ActiveDirectoryToolbelt\logs";
        public static String DEB_LOG_FILE_LOC = LOG_FILE_LOC + @"\debug.log";
        public static String ERR_LOG_FILE_LOC = LOG_FILE_LOC + @"\error.log";
        public static String LOG_FILE_LOC_TEMP = System.IO.Path.GetTempPath();

        /**
         * Program Name
         */
        public static String PROG_NAME = "Active Directory Toolbelt";

        /**
         * Program Version and Build Number
         */

        private static string AssemblyProductVersion
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);
                return attributes.Length == 0 ?
                    "" :
                    ((AssemblyInformationalVersionAttribute)attributes[0]).InformationalVersion;
            }
        }

        public static object? FileVersionInfo { get; set; }

        public String version = AssemblyProductVersion;
        public static String VERSION_NUMBER = "1.0a (build b021)";

        /**
         * Email Information
         * - AWS Regions
         */
        /*
        SMTP_AWS_REGIONS = [
            'us-east-2',       # US East (Ohio)
            'us-east-1',       # US East (N. Virginia)
            'us-west-2',       # US West (Oregon)
            'ap-south-1',      # Asia Pacific (Mumbai)
            'ap-northeast-2',  # Asia Pacific (Seoul)
            'ap-southeast-1',  # Asia Pacific (Singapore)
            'ap-southeast-2',  # Asia Pacific (Sydney)
            'ap-northeast-1',  # Asia Pacific (Tokyo)
            'ca-central-1',    # Canada (Central)
            'eu-central-1',    # Europe (Frankfurt)
            'eu-west-1',       # Europe (Ireland)
            'eu-west-2',       # Europe (London)
            'sa-east-1',       # South America (Sao Paulo)
            'us-gov-west-1',   # AWS GovCloud (US)
        ]
        */
    }
}