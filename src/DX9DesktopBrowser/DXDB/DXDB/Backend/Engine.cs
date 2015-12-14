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
    class Engine {
        private Proc proc;
        public Proc Process { get {return proc;} }


        public Engine(Proc process) {
            proc = process;
        }
    }
}
