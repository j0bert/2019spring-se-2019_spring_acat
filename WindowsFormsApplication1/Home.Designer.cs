﻿namespace WindowsFormsApplication1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ClassesView = new System.Windows.Forms.ListView();
            this.ClassText = new System.Windows.Forms.TextBox();
            this.CRNText = new System.Windows.Forms.TextBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SemesterText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.refreshTextBoxes = new System.Windows.Forms.Button();
            this.Sync_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassesView
            // 
            this.ClassesView.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesView.Location = new System.Drawing.Point(18, 254);
            this.ClassesView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClassesView.Name = "ClassesView";
            this.ClassesView.Size = new System.Drawing.Size(673, 269);
            this.ClassesView.TabIndex = 10;
            this.ClassesView.UseCompatibleStateImageBehavior = false;
            this.ClassesView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ClassesView_ColumnClick);
            this.ClassesView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClassesView_MouseClick);
            this.ClassesView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClassesView_MouseDoubleClick);
            // 
            // ClassText
            // 
            this.ClassText.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassText.Location = new System.Drawing.Point(882, 309);
            this.ClassText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(214, 29);
            this.ClassText.TabIndex = 11;
            // 
            // CRNText
            // 
            this.CRNText.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRNText.Location = new System.Drawing.Point(882, 274);
            this.CRNText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CRNText.Name = "CRNText";
            this.CRNText.Size = new System.Drawing.Size(214, 29);
            this.CRNText.TabIndex = 13;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.ForeColor = System.Drawing.Color.White;
            this.SemesterLabel.Location = new System.Drawing.Point(758, 340);
            this.SemesterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(115, 32);
            this.SemesterLabel.TabIndex = 15;
            this.SemesterLabel.Text = "Semester:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.ForeColor = System.Drawing.Color.White;
            this.ClassLabel.Location = new System.Drawing.Point(730, 309);
            this.ClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(140, 32);
            this.ClassLabel.TabIndex = 17;
            this.ClassLabel.Text = "Class Name:";
            // 
            // Remove_Button
            // 
            this.Remove_Button.BackColor = System.Drawing.Color.Transparent;
            this.Remove_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Button.ForeColor = System.Drawing.Color.White;
            this.Remove_Button.Image = global::WindowsFormsApplication1.Properties.Resources.Subtract;
            this.Remove_Button.Location = new System.Drawing.Point(384, 534);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(123, 117);
            this.Remove_Button.TabIndex = 19;
            this.Remove_Button.UseVisualStyleBackColor = false;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 55);
            this.label2.TabIndex = 21;
            this.label2.Text = "Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(806, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "CRN:";
            // 
            // SemesterText
            // 
            this.SemesterText.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterText.Location = new System.Drawing.Point(882, 345);
            this.SemesterText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SemesterText.Name = "SemesterText";
            this.SemesterText.Size = new System.Drawing.Size(214, 29);
            this.SemesterText.TabIndex = 23;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.White;
            this.yearLabel.Location = new System.Drawing.Point(807, 375);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(64, 32);
            this.yearLabel.TabIndex = 24;
            this.yearLabel.Text = "Year:";
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearText.Location = new System.Drawing.Point(882, 380);
            this.yearText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(214, 29);
            this.yearText.TabIndex = 25;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.Add_Button.Location = new System.Drawing.Point(216, 534);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(123, 117);
            this.Add_Button.TabIndex = 18;
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1023, 0);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(110, 48);
            this.logoutButton.TabIndex = 26;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // refreshTextBoxes
            // 
            this.refreshTextBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.refreshTextBoxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshTextBoxes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTextBoxes.ForeColor = System.Drawing.Color.White;
            this.refreshTextBoxes.Location = new System.Drawing.Point(988, 420);
            this.refreshTextBoxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshTextBoxes.Name = "refreshTextBoxes";
            this.refreshTextBoxes.Size = new System.Drawing.Size(110, 48);
            this.refreshTextBoxes.TabIndex = 28;
            this.refreshTextBoxes.Text = "Clear";
            this.refreshTextBoxes.UseVisualStyleBackColor = false;
            this.refreshTextBoxes.Click += new System.EventHandler(this.refreshTextBoxes_Click);
            // 
            // Sync_Button
            // 
            this.Sync_Button.BackColor = System.Drawing.Color.Transparent;
            this.Sync_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sync_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sync_Button.ForeColor = System.Drawing.Color.White;
            this.Sync_Button.Image = global::WindowsFormsApplication1.Properties.Resources.Webp_net_resizeimage__2_;
            this.Sync_Button.Location = new System.Drawing.Point(975, 531);
            this.Sync_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sync_Button.Name = "Sync_Button";
            this.Sync_Button.Size = new System.Drawing.Size(123, 117);
            this.Sync_Button.TabIndex = 29;
            this.Sync_Button.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1132, 725);
            this.Controls.Add(this.Sync_Button);
            this.Controls.Add(this.refreshTextBoxes);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.SemesterText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.CRNText);
            this.Controls.Add(this.ClassText);
            this.Controls.Add(this.ClassesView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ClassesView;
        private System.Windows.Forms.TextBox ClassText;
        private System.Windows.Forms.TextBox CRNText;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemesterText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button refreshTextBoxes;
        private System.Windows.Forms.Button Sync_Button;
    }
}