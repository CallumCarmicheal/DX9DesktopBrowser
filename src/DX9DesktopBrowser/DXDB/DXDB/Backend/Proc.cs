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
using System;

namespace DXDB.Backend {
    class Proc {
        private int _procID;
        private Process _proc;
        private CaptureProcess _procCapture;
        private bool _isValid;

        public int ProcessID { get { return _procID; } }
        public Process Process { get { return _proc; } }
        public CaptureProcess CaptureProcess { get { return _procCapture; } }
        public bool IsValid { get { return _isValid; } }
        public bool IsRunning { get { return !Process.HasExited; } }
        public IntPtr hTHREAD { get { return this._proc.MainWindowHandle; } }

        private void __init(int ProcID, Process Proc) {
            this._procID = ProcID;
            this._proc = Proc;


            /* var captureInterface = new CaptureInterface();
            captureInterface.RemoteMessage += new MessageReceivedEvent(CaptureInterface_RemoteMessage);
            CaptureConfig cc = new CaptureConfig() {
                Direct3DVersion = Direct3DVersion.AutoDetect,
                ShowOverlay = true
            };

            _procCapture = new CaptureProcess(_proc, cc, captureInterface); */
        }

        void CaptureInterface_RemoteMessage(MessageReceivedEventArgs message) {
            System.Diagnostics.Debugger.Log(0, "CaptureInterface: Remote Message", message.MessageType +  ": " + message.Message);
        }

        private CaptureConfig getConfig() {
            return new CaptureConfig() {
                Direct3DVersion = Direct3DVersion.AutoDetect,
                ShowOverlay = true
            };
        }

        public Proc(string ProcessName) {
            _isValid = ProcessTools.IsOpened(ProcessName);
            if (_isValid) {
                Process proc = ProcessTools.GetProcess(ProcessName, 0);
                __init(proc.Id, proc);
            }
        }

        public Proc(Process proc) {
            __init(proc.Id, proc);
        }


        public Bitmap Capture() {        
            Native.WindowSnap ws = Native.WindowSnap.GetWindowSnap(hTHREAD, true);
            if (ws.Image != null)
                return ws.Image;
            return null;
        }

        public void PressMouseButton(int x, int y) {
            WinAPI.SendMessage(hTHREAD, WinAPI.Input.WM_LBUTTONDOWN, (IntPtr)0, (IntPtr)WinAPI.C.MakeLParam(x, y));
            WinAPI.SendMessage(hTHREAD, WinAPI.Input.WM_LBUTTONUP, (IntPtr)0, (IntPtr)WinAPI.C.MakeLParam(x, y));
        } public void MouseUp(int x, int y) {
            WinAPI.PostMessage(hTHREAD, WinAPI.Input.WM_LBUTTONUP, 0, WinAPI.C.MakeLParam(x, y));
            WinAPI.PostMessage(_proc.Handle, WinAPI.Input.WM_LBUTTONDOWN, 0, WinAPI.C.MakeLParam(x, y));

            WinAPI.SendMessage(hTHREAD, WinAPI.Input.WM_LBUTTONDOWN, (IntPtr)0, (IntPtr)WinAPI.C.MakeLParam(x, y));
            WinAPI.SendMessage(_proc.Handle, WinAPI.Input.WM_LBUTTONDOWN, (IntPtr)0, (IntPtr)WinAPI.C.MakeLParam(x, y));
        } public void MouseDown(int x, int y) {
            WinAPI.PostMessage(hTHREAD, WinAPI.Input.WM_LBUTTONDOWN, 0, WinAPI.C.MakeLParam(x, y));
            WinAPI.PostMessage(_proc.Handle, WinAPI.Input.WM_LBUTTONDOWN, 0, WinAPI.C.MakeLParam(x, y));

            WinAPI.SendMessage(hTHREAD, WinAPI.Input.WM_LBUTTONDOWN, (IntPtr)WinAPI.Input.MK_LBUTTON, (IntPtr)WinAPI.C.MakeLParam(x, y));
            WinAPI.SendMessage(_proc.Handle, WinAPI.Input.WM_LBUTTONDOWN, (IntPtr)WinAPI.Input.MK_LBUTTON, (IntPtr)WinAPI.C.MakeLParam(x, y));
        }
    }
}
