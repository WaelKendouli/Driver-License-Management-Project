using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace clsCreateEventLog
{
    public class clsMyEventLog
    {

        public static bool CreateEventLog( string LogName , string Message , EventLogEntryType logEntryType,string sourceName = "DVLD_EX" )
        {

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, LogName);
            }
            else
            {
                return false;
            }
            EventLog.WriteEntry(sourceName, Message, logEntryType);
            return true;
        }
    }
}
