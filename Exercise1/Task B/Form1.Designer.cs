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
            this.btn_enqueue = new System.Windows.Forms.Button();
            this.btn_dequeue = new System.Windows.Forms.Button();
            this.customerslist = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enqueue
            // 
            this.btn_enqueue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_enqueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enqueue.Location = new System.Drawing.Point(81, 215);
            this.btn_enqueue.Name = "btn_enqueue";
            this.btn_enqueue.Size = new System.Drawing.Size(106, 47);
            this.btn_enqueue.TabIndex = 0;
            this.btn_enqueue.Text = "Enqueue";
            this.btn_enqueue.UseVisualStyleBackColor = false;
            this.btn_enqueue.Click += new System.EventHandler(this.btn_enqueue_Click);
            // 
            // btn_dequeue
            // 
            this.btn_dequeue.BackColor = System.Drawing.Color.IndianRed;
            this.btn_dequeue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dequeue.Location = new System.Drawing.Point(269, 215);
            this.btn_dequeue.Name = "btn_dequeue";
            this.btn_dequeue.Size = new System.Drawing.Size(102, 47);
            this.btn_dequeue.TabIndex = 1;
            this.btn_dequeue.Text = "Dequeue";
            this.btn_dequeue.UseVisualStyleBackColor = false;
            this.btn_dequeue.Click += new System.EventHandler(this.btn_dequeue_Click);
            // 
            // customerslist
            // 
            this.customerslist.FormattingEnabled = true;
            this.customerslist.ItemHeight = 16;
            this.customerslist.Location = new System.Drawing.Point(533, 13);
            this.customerslist.Name = "customerslist";
            this.customerslist.Size = new System.Drawing.Size(255, 420);
            this.customerslist.TabIndex = 4;
            this.customerslist.Tag = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customerslist);
            this.Controls.Add(this.btn_dequeue);
            this.Controls.Add(this.btn_enqueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enqueue;
        private System.Windows.Forms.Button btn_dequeue;
        private System.Windows.Forms.ListBox customerslist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}