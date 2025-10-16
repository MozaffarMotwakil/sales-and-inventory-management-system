using System;
using System.Diagnostics;
using System.Text;

namespace BusinessLogic.Utilities
{
    public static class clsEventLogger
    {
        private const string SourceName = "ERP";

        static clsEventLogger ()
        {
            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
            }
            catch {}
        }

        public static void LogErrorToWindowsEventLog(string contextMessage, Exception ex = null)
        {
            StringBuilder fullMessageBuilder = new StringBuilder();

            fullMessageBuilder.AppendLine($"[رسالة السياق]: {contextMessage}");

            if (ex != null)
            {
                fullMessageBuilder.AppendLine();
                fullMessageBuilder.AppendLine("--- تفاصيل الخطأ الأساسية ---");
                fullMessageBuilder.AppendLine($"نوع الاستثناء: {ex.GetType().FullName}");
                fullMessageBuilder.AppendLine($"رسالة النظام: {ex.Message}");
                fullMessageBuilder.AppendLine($"مصدر الاستثناء: {ex.Source}");
                fullMessageBuilder.AppendLine("-----------------------------");
                fullMessageBuilder.AppendLine();
                fullMessageBuilder.AppendLine("[تتبع المكدس الكامل - Stack Trace]:");
                fullMessageBuilder.AppendLine(ex.ToString());
            }

            EventLog.WriteEntry(SourceName, fullMessageBuilder.ToString(), EventLogEntryType.Error);
        }

    }
}
