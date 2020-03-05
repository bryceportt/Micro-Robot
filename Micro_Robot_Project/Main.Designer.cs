namespace Micro_Robot_Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CenterButton = new System.Windows.Forms.Button();
            this.USB_DEVICES = new System.Windows.Forms.Button();
            this.Initialize_Communication = new System.Windows.Forms.Button();
            this.DownRightButton = new System.Windows.Forms.Button();
            this.DownLeftButton = new System.Windows.Forms.Button();
            this.UpRightButton = new System.Windows.Forms.Button();
            this.UpLeftButton = new System.Windows.Forms.Button();
            this.Down_button = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.Leftbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(548, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Micro-Robot Manual Control";
            // 
            // CenterButton
            // 
            this.CenterButton.BackColor = System.Drawing.Color.Gray;
            this.CenterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CenterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenterButton.Location = new System.Drawing.Point(622, 118);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(75, 75);
            this.CenterButton.TabIndex = 7;
            this.CenterButton.Text = "CENTER";
            this.CenterButton.UseVisualStyleBackColor = false;
            this.CenterButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CenterButton_MouseDown);
            this.CenterButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CenterButton_MouseUp);
            // 
            // USB_DEVICES
            // 
            this.USB_DEVICES.Location = new System.Drawing.Point(12, 337);
            this.USB_DEVICES.Name = "USB_DEVICES";
            this.USB_DEVICES.Size = new System.Drawing.Size(92, 23);
            this.USB_DEVICES.TabIndex = 9;
            this.USB_DEVICES.Text = "USB Devices";
            this.USB_DEVICES.UseVisualStyleBackColor = true;
            this.USB_DEVICES.Click += new System.EventHandler(this.USB_DEVICES_Click);
            // 
            // Initialize_Communication
            // 
            this.Initialize_Communication.BackColor = System.Drawing.Color.Gray;
            this.Initialize_Communication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Initialize_Communication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Initialize_Communication.Location = new System.Drawing.Point(541, 281);
            this.Initialize_Communication.Name = "Initialize_Communication";
            this.Initialize_Communication.Size = new System.Drawing.Size(237, 50);
            this.Initialize_Communication.TabIndex = 10;
            this.Initialize_Communication.Text = "Initialize Communication";
            this.Initialize_Communication.UseVisualStyleBackColor = false;
            this.Initialize_Communication.Click += new System.EventHandler(this.Initialize_Communication_Click);
            // 
            // DownRightButton
            // 
            this.DownRightButton.BackColor = System.Drawing.Color.Gray;
            this.DownRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DownRightButton.Image = global::Micro_Robot_Project.Properties.Resources.down_right_arrow;
            this.DownRightButton.Location = new System.Drawing.Point(703, 199);
            this.DownRightButton.Name = "DownRightButton";
            this.DownRightButton.Size = new System.Drawing.Size(75, 75);
            this.DownRightButton.TabIndex = 14;
            this.DownRightButton.UseVisualStyleBackColor = false;
            // 
            // DownLeftButton
            // 
            this.DownLeftButton.BackColor = System.Drawing.Color.Gray;
            this.DownLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DownLeftButton.Image = global::Micro_Robot_Project.Properties.Resources.down_left_arrow;
            this.DownLeftButton.Location = new System.Drawing.Point(541, 199);
            this.DownLeftButton.Name = "DownLeftButton";
            this.DownLeftButton.Size = new System.Drawing.Size(75, 75);
            this.DownLeftButton.TabIndex = 13;
            this.DownLeftButton.UseVisualStyleBackColor = false;
            // 
            // UpRightButton
            // 
            this.UpRightButton.BackColor = System.Drawing.Color.Gray;
            this.UpRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpRightButton.Image = global::Micro_Robot_Project.Properties.Resources.up_right_arrow;
            this.UpRightButton.Location = new System.Drawing.Point(703, 37);
            this.UpRightButton.Name = "UpRightButton";
            this.UpRightButton.Size = new System.Drawing.Size(75, 75);
            this.UpRightButton.TabIndex = 12;
            this.UpRightButton.UseVisualStyleBackColor = false;
            this.UpRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpRightButton_MouseDown);
            this.UpRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpRightButton_MouseUp);
            // 
            // UpLeftButton
            // 
            this.UpLeftButton.BackColor = System.Drawing.Color.Gray;
            this.UpLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpLeftButton.Image = global::Micro_Robot_Project.Properties.Resources.up_left_arrow;
            this.UpLeftButton.Location = new System.Drawing.Point(541, 37);
            this.UpLeftButton.Name = "UpLeftButton";
            this.UpLeftButton.Size = new System.Drawing.Size(75, 75);
            this.UpLeftButton.TabIndex = 11;
            this.UpLeftButton.UseVisualStyleBackColor = false;
            this.UpLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpLeftButton_MouseDown);
            this.UpLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpLeftButton_MouseUp);
            // 
            // Down_button
            // 
            this.Down_button.BackColor = System.Drawing.Color.Gray;
            this.Down_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Down_button.ForeColor = System.Drawing.Color.White;
            this.Down_button.Image = global::Micro_Robot_Project.Properties.Resources.down;
            this.Down_button.Location = new System.Drawing.Point(622, 199);
            this.Down_button.Name = "Down_button";
            this.Down_button.Size = new System.Drawing.Size(75, 75);
            this.Down_button.TabIndex = 6;
            this.Down_button.UseVisualStyleBackColor = false;
            this.Down_button.Click += new System.EventHandler(this.Down_button_Click);
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.Gray;
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RightButton.ForeColor = System.Drawing.Color.White;
            this.RightButton.Image = global::Micro_Robot_Project.Properties.Resources.right;
            this.RightButton.Location = new System.Drawing.Point(703, 118);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 75);
            this.RightButton.TabIndex = 5;
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // Leftbutton
            // 
            this.Leftbutton.BackColor = System.Drawing.Color.Gray;
            this.Leftbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Leftbutton.ForeColor = System.Drawing.Color.White;
            this.Leftbutton.Image = global::Micro_Robot_Project.Properties.Resources.left;
            this.Leftbutton.Location = new System.Drawing.Point(541, 118);
            this.Leftbutton.Name = "Leftbutton";
            this.Leftbutton.Size = new System.Drawing.Size(75, 75);
            this.Leftbutton.TabIndex = 4;
            this.Leftbutton.UseVisualStyleBackColor = false;
            this.Leftbutton.Click += new System.EventHandler(this.Leftbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Micro_Robot_Project.Properties.Resources.up;
            this.button1.Location = new System.Drawing.Point(622, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpButton_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpButton_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 319);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DownRightButton);
            this.Controls.Add(this.DownLeftButton);
            this.Controls.Add(this.UpRightButton);
            this.Controls.Add(this.UpLeftButton);
            this.Controls.Add(this.Initialize_Communication);
            this.Controls.Add(this.USB_DEVICES);
            this.Controls.Add(this.CenterButton);
            this.Controls.Add(this.Down_button);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.Leftbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Main";
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Leftbutton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button Down_button;
        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.Button USB_DEVICES;
        private System.Windows.Forms.Button Initialize_Communication;
        private System.Windows.Forms.Button UpLeftButton;
        private System.Windows.Forms.Button UpRightButton;
        private System.Windows.Forms.Button DownLeftButton;
        private System.Windows.Forms.Button DownRightButton;
    }
}

