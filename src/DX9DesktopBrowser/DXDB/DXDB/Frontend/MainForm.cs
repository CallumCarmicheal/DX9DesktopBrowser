using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXDB.Frontend {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            OnTick.Start();

            string procTxt = "skype.exe";
            if (!Backend.ProcessTools.IsOpened(procTxt)) { MessageBox.Show("Process is not valid"); return; }
            Proc = new Backend.Proc(procTxt);
        }

        private Backend.Proc Proc;
        private bool winMove_mouseDown = false;
        private Point winMove_lastLocation;
        private void MinimiseForm(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void ExitForm(object sender, EventArgs e) { this.Close(); }
        private void winMove_OnMouseDown(object sender, MouseEventArgs e) {
            winMove_mouseDown = true; winMove_lastLocation = e.Location;
        } private void winMove_OnMouseUp(object sender, MouseEventArgs e) {
            winMove_mouseDown = false;
        } private void winMove_OnMouseMove(object sender, MouseEventArgs e) {
            if (winMove_mouseDown) {
                this.Location = new Point((this.Location.X - winMove_lastLocation.X) + e.X, (this.Location.Y - winMove_lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void SelectProcess(object sender, EventArgs e) {
            string procTxt = Desktop_Capture_Process.Text;
            if (!Backend.ProcessTools.IsOpened(procTxt)) { MessageBox.Show("Process is not valid"); return; }
            Proc = new Backend.Proc(procTxt);
        }

        private void Desktop_Capture_CaptureProcess(object sender, EventArgs e) {
            if (this.Proc == null) {
                MessageBox.Show("Please enter the process above."); return;
            }

            Bitmap image = Proc.Capture();
            if (image == null) {
                MessageBox.Show("Could not capture process at the moment."); return;
            }

            SetImage(image);
            image.Dispose();
        }

        private void SetImage(Bitmap image) {
            //Desktop_Capture_Image.Image = image;
            Desktop_Mouse_Image.Image = image;
            //Desktop_Mouse_Image.Update();
        }

        private void OnTimerTick(object sender, EventArgs e) {
            Color resultColor = Color.Black;
            string status = "Error";
            {
                if (Proc == null) {
                    status = "Not Defined";
                    resultColor = Color.Orange;
                } else if (Proc.IsRunning) {
                    status = "Opened and Running";
                    resultColor = Color.Green;

                    Bitmap image = Proc.Capture();
                    if (image == null) {
                        MessageBox.Show("Could not capture process at the moment.");
                    } else {
                        SetImage(image);
                    }
                } else if (Proc.IsValid) {
                    status = "Valid but Not Running";
                    resultColor = Color.Orange;
                }
            } 
            ProcessStatus.ForeColor = resultColor;
            ProcessStatus.Text = "Process Status: " + status;


        }

        private void Desktop_Mouse_Capture(object sender, EventArgs e) {
            if (this.Proc == null) {
                MessageBox.Show("Please enter the process above."); return;
            }

            Bitmap image = Proc.Capture();
            if (image == null) {
                MessageBox.Show("Could not capture process at the moment."); return;
            }

            SetImage(image);
        }

        private void Desktop_Image_MouseDown(object sender, MouseEventArgs e) {
            Point f = e.Location;
            Point lp = Desktop_Mouse_Image.PointToClient(Cursor.Position);
            label4.Text = "Frame X,Y (" + f.X + ", " + f.Y + ")";
            label5.Text = "Real X,Y (" + lp.X + ", " + lp.Y + ")";
            label7.Text = "Mouse Status: Down";

            if (this.Proc == null) {
                MessageBox.Show("Please enter the process above."); return;
            }

            Proc.MouseDown(lp.X, lp.Y);
            //Proc.PressMouseButton();
        }

        private void Desktop_Image_MouseUp(object sender, MouseEventArgs e) {
            Point f = e.Location;
            Point lp = Desktop_Mouse_Image.PointToClient(Cursor.Position);
            label7.Text = "Mouse Status: Up";

            if (this.Proc == null) {
                MessageBox.Show("Please enter the process above."); return;
            }

            Proc.MouseUp(lp.X, lp.Y);
        }
    }
}
