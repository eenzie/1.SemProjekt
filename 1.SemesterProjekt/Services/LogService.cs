using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Services {

    /// <summary>
    /// Written by Anton
    /// </summary>
    public static class LogService {
        // This will store the filepath to the logfile
        private readonly static string _fileName = "LogFile.txt";

        // Event that the UI can listen to
        public static event EventHandler<string> ExceptionCaught;


        /// <summary>
        /// This will log the error to the file and invoke the event
        /// </summary>
        /// <param name="errorMessage">The error message</param>
        /// <param name="className">The class from which the error happened</param>
        /// <param name="methodName">The method from which the error happened</param>
        public static void LogError(string errorMessage, string className, string methodName) {
            // If the log file does not exist, we create it with a header
            if (!File.Exists(_fileName)) {
                InitErrorFile();
            }
            // We write the message to the file with a timestamp
            using (StreamWriter streamWriter = new StreamWriter(File.Open(_fileName, FileMode.Append))) {
                string formattedMessage = string.Format("{0, -25} {1,-30} {2, -30} {3}", DateTime.Now.ToString("yyyy/MM/dd hh:MM:ss"), className, methodName, errorMessage);
                streamWriter.WriteLine(formattedMessage);
                ExceptionCaught.Invoke(null, errorMessage);
            }
        }

        /// <summary>
        /// This will create the log file with the header
        /// </summary>
        private static void InitErrorFile() {
            using (StreamWriter streamWriter = new StreamWriter(File.Open(_fileName, FileMode.Create))) {
                string formattedMessage = string.Format("{0, -25} {1,-30} {2, -30} {3}", "Tidspunkt", "Klasse", "Metode", "Besked");
                streamWriter.WriteLine(formattedMessage);
            }
        }
    }
}
