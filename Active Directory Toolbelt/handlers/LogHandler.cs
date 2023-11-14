using Active_Directory_Toolbelt.utils;
using Sentry;
using System.Diagnostics;
using System.IO;

/*
 * Aviva Policy Book Deployment Tool V2
 * Developed by @ Dean Reid
 *
 * Class Name: LogHandler
 *
 * Class Information:
 *
 * Class handles ability to throw either an error or general debug info
 *
 * Program Version: 1.0
 * Code Version: 2.3
 *
 * Updates:
 * 14/04/2020 - Initial Code Development
 * 21/06/2021 - Add Error Logging
 * 01/07/2021 - Add Event Viewer Logging
 * 20/10/2021 - Fix issue where log not dumped to file
 */

namespace Active_Directory_Toolbelt.handlers
{
    internal class LogHandler
    {
        private static LogBase? logger;

        public static void Log(LogTarget target, string message)
        {
            switch (target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(message);
                    break;

                case LogTarget.Database:
                    logger = new DBLogger();
                    logger.Log(message);
                    break;

                case LogTarget.EventLog:
                    logger = new EventLogger();
                    logger.Log(message);
                    break;

                default:
                    return;
            }
        }

        public static void ErrorLog(LogTarget target, string message)
        {
            switch (target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(message);
                    break;

                case LogTarget.Database:
                    logger = new DBLogger();
                    logger.Log(message);
                    break;

                case LogTarget.EventLog:
                    logger = new EventLogger();
                    logger.Log(message);
                    break;

                default:
                    return;
            }
        }

        public enum LogTarget
        {
            File, Database, EventLog
        }

        public abstract class LogBase
        {
            public abstract void Log(string message);

            public abstract void ErrorLog(string message);
        }

        public class FileLogger : LogBase
        {
            public override void Log(string message)
            {
                using (StreamWriter streamWriter = new StreamWriter(Reference.DEB_LOG_FILE_LOC, true))
                {
                    if (Reference.DEBUG_MODE)
                    {
                        streamWriter.WriteLine(DateTimeOffset.Now + ": " + message);
                        streamWriter.Close();
                        Console.WriteLine(DateTimeOffset.Now + ": " + message);
                    }
                }
            }

            public override void ErrorLog(string message)
            {
                using (StreamWriter streamWriter = new StreamWriter(Reference.ERR_LOG_FILE_LOC, true))
                {
                    SentrySdk.CaptureMessage(DateTimeOffset.Now + " ERROR:: " + message);
                    streamWriter.WriteLine(DateTimeOffset.Now + " ERROR:: " + message);
                    streamWriter.Close();

                    Console.WriteLine(DateTimeOffset.Now + " ERROR:: " + message);
                }
            }
        }

        public class DBLogger : LogBase
        {
            private readonly string connectionString = string.Empty;

            public override void Log(string message)
            {
                //Code to log data to the database
            }

            public override void ErrorLog(string message)
            {
                //Code to log data to the database
            }
        }

        public class EventLogger : LogBase
        {
            public override void Log(string message)
            {
                EventLog eventLog = new EventLog("")
                {
                    Source = "Aviva Policy Book Deployment Tool"
                    //Source = "IDGEventLog"
                };
                eventLog.WriteEntry(message);
            }

            public override void ErrorLog(string message)
            {
                EventLog eventLog = new EventLog("")
                {
                    Source = "Aviva Policy Book Deployment Tool"
                };
                eventLog.WriteEntry(message);
            }
        }
    }
}