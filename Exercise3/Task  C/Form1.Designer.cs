namespace Task__C
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.enrollmentStatus = new System.Windows.Forms.ListBox();
            this.DisplayAllStudents = new System.Windows.Forms.ListBox();
            this.displaysStudentButton = new System.Windows.Forms.Button();
            this.displayinfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student ID:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateButton.Location = new System.Drawing.Point(103, 215);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(222, 37);
            this.UpdateButton.TabIndex = 19;
            this.UpdateButton.Text = "Update Enrollment Status";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayButton.Location = new System.Drawing.Point(103, 352);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(222, 37);
            this.DisplayButton.TabIndex = 18;
            this.DisplayButton.Text = "Display Enrollment Status";
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(241, 149);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(108, 37);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(46, 107);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(336, 22);
            this.nametextbox.TabIndex = 16;
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(46, 56);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(336, 22);
            this.idtextbox.TabIndex = 15;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(73, 149);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(108, 37);
            this.InsertButton.TabIndex = 14;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // enrollmentStatus
            // 
            this.enrollmentStatus.FormattingEnabled = true;
            this.enrollmentStatus.ItemHeight = 16;
            this.enrollmentStatus.Location = new System.Drawing.Point(88, 310);
            this.enrollmentStatus.Name = "enrollmentStatus";
            this.enrollmentStatus.Size = new System.Drawing.Size(252, 36);
            this.enrollmentStatus.TabIndex = 13;
            // 
            // DisplayAllStudents
            // 
            this.DisplayAllStudents.FormattingEnabled = true;
            this.DisplayAllStudents.ItemHeight = 16;
            this.DisplayAllStudents.Location = new System.Drawing.Point(530, 31);
            this.DisplayAllStudents.Name = "DisplayAllStudents";
            this.DisplayAllStudents.Size = new System.Drawing.Size(244, 260);
            this.DisplayAllStudents.TabIndex = 22;
            // 
            // displaysStudentButton
            // 
            this.displaysStudentButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displaysStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaysStudentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displaysStudentButton.Location = new System.Drawing.Point(540, 297);
            this.displaysStudentButton.Name = "displaysStudentButton";
            this.displaysStudentButton.Size = new System.Drawing.Size(222, 37);
            this.displaysStudentButton.TabIndex = 23;
            this.displaysStudentButton.Text = "Display Enrolled Students";
            this.displaysStudentButton.UseVisualStyleBackColor = false;
            this.displaysStudentButton.Click += new System.EventHandler(this.displaysStudentButton_Click);
            // 
            // displayinfo
            // 
            this.displayinfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displayinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayinfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayinfo.Location = new System.Drawing.Point(540, 352);
            this.displayinfo.Name = "displayinfo";
            this.displayinfo.Size = new System.Drawing.Size(222, 37);
            this.displayinfo.TabIndex = 24;
            this.displayinfo.Text = "Display Student Information";
            this.displayinfo.UseVisualStyleBackColor = false;
            this.displayinfo.Click += new System.EventHandler(this.displayinfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayinfo);
            this.Controls.Add(this.displaysStudentButton);
            this.Controls.Add(this.DisplayAllStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.enrollmentStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ListBox enrollmentStatus;
        private System.Windows.Forms.ListBox DisplayAllStudents;
        private System.Windows.Forms.Button displaysStudentButton;
        private System.Windows.Forms.Button displayinfo;
    }
}

