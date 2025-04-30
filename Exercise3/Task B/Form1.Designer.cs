namespace Task_B
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
            this.enrollmentStatus = new System.Windows.Forms.ListBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enrollmentStatus
            // 
            this.enrollmentStatus.FormattingEnabled = true;
            this.enrollmentStatus.ItemHeight = 16;
            this.enrollmentStatus.Location = new System.Drawing.Point(250, 321);
            this.enrollmentStatus.Name = "enrollmentStatus";
            this.enrollmentStatus.Size = new System.Drawing.Size(252, 36);
            this.enrollmentStatus.TabIndex = 2;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(235, 175);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(108, 37);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(208, 82);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(336, 22);
            this.idtextbox.TabIndex = 5;
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(208, 133);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(336, 22);
            this.nametextbox.TabIndex = 6;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(403, 175);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(108, 37);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayButton.Location = new System.Drawing.Point(265, 363);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(222, 37);
            this.DisplayButton.TabIndex = 8;
            this.DisplayButton.Text = "Display Enrollment Status";
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateButton.Location = new System.Drawing.Point(265, 241);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(222, 37);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update Enrollment Status";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(207, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ListBox enrollmentStatus;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

