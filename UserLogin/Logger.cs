using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
                + LoginValidation.currentUserRole + ";"
                + activity;

            currentSessionActivities.Add(activityLine);

            if (File.Exists("test.txt"))
            {
                File.WriteAllText("test.txt", activityLine);
            }
        }

        static public IEnumerable<string> GetCurrentSessionActivities(string Filter)
        {

            List<string> filteredActivities = (from activity in currentSessionActivities
                                               where activity.Contains(Filter)
                                               select activity).ToList();
            return filteredActivities;
        }
    }
}
