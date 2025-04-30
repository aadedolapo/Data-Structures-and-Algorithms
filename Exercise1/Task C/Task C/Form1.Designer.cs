namespace Task_C
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
            this.customerslist = new System.Windows.Forms.ListBox();
            this.btn_dequeue = new System.Windows.Forms.Button();
            this.btn_enqueue = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_reverse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 22);
            this.textBox1.TabIndex = 11;
            // 
            // customerslist
            // 
            this.customerslist.FormattingEnabled = true;
            this.customerslist.ItemHeight = 16;
            this.customerslist.Location = new System.Drawing.Point(535, 7);
            this.customerslist.Name = "customerslist";
            this.customerslist.Size = new System.Drawing.Size(255, 436);
            this.customerslist.TabIndex = 10;
            // 
            // btn_dequeue
            // 
            this.btn_dequeue.BackColor = System.Drawing.Color.IndianRed;
            this.btn_dequeue.Location = new System.Drawing.Point(276, 158);
            this.btn_dequeue.Name = "btn_dequeue";
            this.btn_dequeue.Size = new System.Drawing.Size(86, 38);
            this.btn_dequeue.TabIndex = 8;
            this.btn_dequeue.Text = "Dequeue";
            this.btn_dequeue.UseVisualStyleBackColor = false;
            this.btn_dequeue.Click += new System.EventHandler(this.btn_dequeue_Click);
            // 
            // btn_enqueue
            // 
            this.btn_enqueue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_enqueue.Location = new System.Drawing.Point(158, 158);
            this.btn_enqueue.Name = "btn_enqueue";
            this.btn_enqueue.Size = new System.Drawing.Size(87, 38);
            this.btn_enqueue.TabIndex = 7;
            this.btn_enqueue.Text = "Enqueue";
            this.btn_enqueue.UseVisualStyleBackColor = false;
            this.btn_enqueue.Click += new System.EventHandler(this.btn_enqueue_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 22);
            this.textBox2.TabIndex = 13;
            // 
            // btn_reverse
            // 
            this.btn_reverse.BackColor = System.Drawing.Color.IndianRed;
            this.btn_reverse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reverse.Location = new System.Drawing.Point(194, 345);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(136, 45);
            this.btn_reverse.TabIndex = 14;
            this.btn_reverse.Text = "Reverse";
            this.btn_reverse.UseVisualStyleBackColor = false;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(231, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(81, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer\'s Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Customer\'s Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reverse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customerslist);
            this.Controls.Add(this.btn_dequeue);
            this.Controls.Add(this.btn_enqueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox customerslist;
        private System.Windows.Forms.Button btn_dequeue;
        private System.Windows.Forms.Button btn_enqueue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_reverse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

