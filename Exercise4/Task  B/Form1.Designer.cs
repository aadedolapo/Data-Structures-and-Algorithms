namespace Task__B
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_add_person = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_direct_edge = new System.Windows.Forms.Button();
            this.btn_display_all = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_direct_friends = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 22);
            this.textBox1.TabIndex = 24;
            // 
            // btn_add_person
            // 
            this.btn_add_person.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_person.Location = new System.Drawing.Point(222, 94);
            this.btn_add_person.Name = "btn_add_person";
            this.btn_add_person.Size = new System.Drawing.Size(106, 47);
            this.btn_add_person.TabIndex = 22;
            this.btn_add_person.Text = "Add Person";
            this.btn_add_person.UseVisualStyleBackColor = false;
            this.btn_add_person.Click += new System.EventHandler(this.btn_add_person_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Person:";
            // 
            // btn_add_direct_edge
            // 
            this.btn_add_direct_edge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add_direct_edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_direct_edge.Location = new System.Drawing.Point(383, 94);
            this.btn_add_direct_edge.Name = "btn_add_direct_edge";
            this.btn_add_direct_edge.Size = new System.Drawing.Size(147, 47);
            this.btn_add_direct_edge.TabIndex = 26;
            this.btn_add_direct_edge.Text = "Add Direct Edge";
            this.btn_add_direct_edge.UseVisualStyleBackColor = false;
            this.btn_add_direct_edge.Click += new System.EventHandler(this.btn_add_direct_edge_Click);
            // 
            // btn_display_all
            // 
            this.btn_display_all.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_display_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display_all.Location = new System.Drawing.Point(149, 392);
            this.btn_display_all.Name = "btn_display_all";
            this.btn_display_all.Size = new System.Drawing.Size(179, 47);
            this.btn_display_all.TabIndex = 27;
            this.btn_display_all.Text = "Display All Persons";
            this.btn_display_all.UseVisualStyleBackColor = false;
            this.btn_display_all.Click += new System.EventHandler(this.btn_display_all_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(673, 164);
            this.listBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 353);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 22);
            this.textBox2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Search Friends";
            // 
            // btn_direct_friends
            // 
            this.btn_direct_friends.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_direct_friends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_direct_friends.Location = new System.Drawing.Point(417, 392);
            this.btn_direct_friends.Name = "btn_direct_friends";
            this.btn_direct_friends.Size = new System.Drawing.Size(179, 47);
            this.btn_direct_friends.TabIndex = 31;
            this.btn_direct_friends.Text = "Display Direct Friends";
            this.btn_direct_friends.UseVisualStyleBackColor = false;
            this.btn_direct_friends.Click += new System.EventHandler(this.btn_direct_friends_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "NOTE: To add direct edges, you need to add two names seperated with a \',\'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_direct_friends);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_display_all);
            this.Controls.Add(this.btn_add_direct_edge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_add_person);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add_person;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_direct_edge;
        private System.Windows.Forms.Button btn_display_all;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_direct_friends;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

