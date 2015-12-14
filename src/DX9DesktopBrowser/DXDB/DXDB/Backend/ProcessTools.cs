using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using EasyHook;
using System.Runtime.Remoting;
using System.Runtime.InteropServices;
using System.IO;
using Capture.Interface;
using Capture.Hook;
using Capture;

namespace DXDB.Backend {
    class ProcessTools {

        public static bool IsOpened(string procName) {
            Process[] procs = Process.GetProcessesByName(procName);
            return (procs.Count() == 0);
        }

        public static Process GetProcess(string procName, int Index = 0) {
            Process[] processes = Process.GetProcessesByName(procName.Replace(".exe", ""));

            if (IsOpened(procName))
                return processes[Index];
            return null;
        }
    }
}
