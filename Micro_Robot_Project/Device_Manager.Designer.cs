namespace Micro_Robot_Project
{
    partial class Device_Manager
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
            this.availableResourcesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Left_Coil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Right_Coil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.BackColor = System.Drawing.Color.Gray;
            this.availableResourcesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableResourcesListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.availableResourcesListBox.Location = new System.Drawing.Point(12, 30);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(302, 143);
            this.availableResourcesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available USB Devices";
            // 
            // Left_Coil
            // 
            this.Left_Coil.BackColor = System.Drawing.Color.Gray;
            this.Left_Coil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Left_Coil.ForeColor = System.Drawing.Color.White;
            this.Left_Coil.Location = new System.Drawing.Point(12, 200);
            this.Left_Coil.Name = "Left_Coil";
            this.Left_Coil.Size = new System.Drawing.Size(75, 23);
            this.Left_Coil.TabIndex = 2;
            this.Left_Coil.Text = "Left Coil";
            this.Left_Coil.UseVisualStyleBackColor = false;
            this.Left_Coil.Click += new System.EventHandler(this.Left_Coil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Select the device for your desired configuration";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Gray;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_Button.ForeColor = System.Drawing.Color.White;
            this.Close_Button.Location = new System.Drawing.Point(239, 248);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 23);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Right_Coil
            // 
            this.Right_Coil.BackColor = System.Drawing.Color.Gray;
            this.Right_Coil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Right_Coil.ForeColor = System.Drawing.Color.White;
            this.Right_Coil.Location = new System.Drawing.Point(12, 229);
            this.Right_Coil.Name = "Right_Coil";
            this.Right_Coil.Size = new System.Drawing.Size(75, 23);
            this.Right_Coil.TabIndex = 5;
            this.Right_Coil.Text = "Right Coil";
            this.Right_Coil.UseVisualStyleBackColor = false;
            this.Right_Coil.Click += new System.EventHandler(this.Right_Coil_Click);
            // 
            // Device_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(326, 274);
            this.Controls.Add(this.Right_Coil);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Left_Coil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availableResourcesListBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Device_Manager";
            this.Text = "Device Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availableResourcesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Left_Coil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Right_Coil;
    }
}