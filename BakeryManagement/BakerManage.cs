using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryManagement
{
    public static class BakerManage
    {
        private static List<string> messages = new List<string>();

        public static List<string> Messages {
            get { return messages; }
        }

        public static void AddMessage(string message)
        {
            messages.Add(message);
        }

        public static void ClearMessages()
        {
            messages.Clear();
        }
    }
}
