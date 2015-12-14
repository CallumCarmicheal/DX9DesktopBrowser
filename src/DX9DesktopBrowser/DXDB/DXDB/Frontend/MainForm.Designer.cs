namespace DXDB.Frontend {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Desktop_Capture_Process = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessStatus = new System.Windows.Forms.Label();
            this.OnTick = new System.Windows.Forms.Timer(this.components);
            this.TabBar = new Avalon.Stealth.Controls.Avast();
            this.Header_Desktop = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Desktop_Capture_Image = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Desktop_Mouse_Image = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TabBar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Desktop_Capture_Image)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Desktop_Mouse_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(731, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.MinimiseForm);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(767, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.ExitForm);
            // 
            // Desktop_Capture_Process
            // 
            this.Desktop_Capture_Process.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desktop_Capture_Process.Location = new System.Drawing.Point(388, 9);
            this.Desktop_Capture_Process.Name = "Desktop_Capture_Process";
            this.Desktop_Capture_Process.Size = new System.Drawing.Size(337, 22);
            this.Desktop_Capture_Process.TabIndex = 2;
            this.Desktop_Capture_Process.Text = "Skype.exe";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(284, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectProcess);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Juice ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Playground ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.winMove_OnMouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.winMove_OnMouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.winMove_OnMouseUp);
            // 
            // ProcessStatus
            // 
            this.ProcessStatus.AutoSize = true;
            this.ProcessStatus.ForeColor = System.Drawing.Color.White;
            this.ProcessStatus.Location = new System.Drawing.Point(388, 32);
            this.ProcessStatus.Name = "ProcessStatus";
            this.ProcessStatus.Size = new System.Drawing.Size(120, 13);
            this.ProcessStatus.TabIndex = 6;
            this.ProcessStatus.Text = "Process Status: Waiting";
            // 
            // OnTick
            // 
            this.OnTick.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // TabBar
            // 
            this.TabBar.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabBar.Controls.Add(this.Header_Desktop);
            this.TabBar.Controls.Add(this.tabPage2);
            this.TabBar.Controls.Add(this.tabPage1);
            this.TabBar.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabBar.Font = new System.Drawing.Font("Verdana", 8F);
            this.TabBar.ImageList_Selected = null;
            this.TabBar.ImageList_Unselected = null;
            this.TabBar.ItemSize = new System.Drawing.Size(21, 180);
            this.TabBar.Location = new System.Drawing.Point(1, 49);
            this.TabBar.Multiline = true;
            this.TabBar.Name = "TabBar";
            this.TabBar.SelectedIndex = 0;
            this.TabBar.Size = new System.Drawing.Size(810, 496);
            this.TabBar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabBar.TabIndex = 0;
            // 
            // Header_Desktop
            // 
            this.Header_Desktop.Location = new System.Drawing.Point(184, 4);
            this.Header_Desktop.Name = "Header_Desktop";
            this.Header_Desktop.Padding = new System.Windows.Forms.Padding(3);
            this.Header_Desktop.Size = new System.Drawing.Size(622, 488);
            this.Header_Desktop.TabIndex = 0;
            this.Header_Desktop.Tag = "header";
            this.Header_Desktop.Text = "Desktop";
            this.Header_Desktop.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Desktop_Capture_Image);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Capture Application";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(610, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Capture Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Desktop_Capture_CaptureProcess);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // Desktop_Capture_Image
            // 
            this.Desktop_Capture_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desktop_Capture_Image.Location = new System.Drawing.Point(6, 44);
            this.Desktop_Capture_Image.Name = "Desktop_Capture_Image";
            this.Desktop_Capture_Image.Size = new System.Drawing.Size(610, 438);
            this.Desktop_Capture_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Desktop_Capture_Image.TabIndex = 0;
            this.Desktop_Capture_Image.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.Desktop_Mouse_Image);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 488);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test Mouse Clicks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Real X (0) - Real Y (0)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Frame X (0) - Frame Y (0)";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Capture Process";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Desktop_Mouse_Capture);
            // 
            // Desktop_Mouse_Image
            // 
            this.Desktop_Mouse_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desktop_Mouse_Image.Location = new System.Drawing.Point(6, 51);
            this.Desktop_Mouse_Image.Name = "Desktop_Mouse_Image";
            this.Desktop_Mouse_Image.Size = new System.Drawing.Size(610, 431);
            this.Desktop_Mouse_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Desktop_Mouse_Image.TabIndex = 8;
            this.Desktop_Mouse_Image.TabStop = false;
            this.Desktop_Mouse_Image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Desktop_Image_MouseDown);
            this.Desktop_Mouse_Image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Desktop_Image_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mouse Status: Up";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(809, 544);
            this.Controls.Add(this.ProcessStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Desktop_Capture_Process);
            this.Controls.Add(this.TabBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Direct X Playground";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.winMove_OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.winMove_OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.winMove_OnMouseUp);
            this.TabBar.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Desktop_Capture_Image)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Desktop_Mouse_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Avalon.Stealth.Controls.Avast TabBar;
        private System.Windows.Forms.TabPage Header_Desktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Desktop_Capture_Process;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Desktop_Capture_Image;
        private System.Windows.Forms.Label ProcessStatus;
        private System.Windows.Forms.Timer OnTick;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox Desktop_Mouse_Image;
        private System.Windows.Forms.Label label7;
    }
}