namespace Fle_Read_Wrte_Append
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
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_append = new System.Windows.Forms.Button();
            this.txt_read = new System.Windows.Forms.TextBox();
            this.txt_write = new System.Windows.Forms.TextBox();
            this.txt_Append = new System.Windows.Forms.TextBox();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(390, 109);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(390, 208);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(75, 23);
            this.btn_write.TabIndex = 1;
            this.btn_write.Text = "Wrte";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_append
            // 
            this.btn_append.Location = new System.Drawing.Point(390, 300);
            this.btn_append.Name = "btn_append";
            this.btn_append.Size = new System.Drawing.Size(75, 23);
            this.btn_append.TabIndex = 2;
            this.btn_append.Text = "Append";
            this.btn_append.UseVisualStyleBackColor = true;
            this.btn_append.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_read
            // 
            this.txt_read.Location = new System.Drawing.Point(104, 90);
            this.txt_read.Multiline = true;
            this.txt_read.Name = "txt_read";
            this.txt_read.Size = new System.Drawing.Size(156, 58);
            this.txt_read.TabIndex = 3;
            // 
            // txt_write
            // 
            this.txt_write.Location = new System.Drawing.Point(104, 189);
            this.txt_write.Multiline = true;
            this.txt_write.Name = "txt_write";
            this.txt_write.Size = new System.Drawing.Size(156, 62);
            this.txt_write.TabIndex = 4;
            // 
            // txt_Append
            // 
            this.txt_Append.Location = new System.Drawing.Point(104, 277);
            this.txt_Append.Multiline = true;
            this.txt_Append.Name = "txt_Append";
            this.txt_Append.Size = new System.Drawing.Size(168, 60);
            this.txt_Append.TabIndex = 5;
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(104, 34);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(156, 20);
            this.tb_fileName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fle name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.txt_Append);
            this.Controls.Add(this.txt_write);
            this.Controls.Add(this.txt_read);
            this.Controls.Add(this.btn_append);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Name = "Form1";
            this.Text = "Fle Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_append;
        private System.Windows.Forms.TextBox txt_read;
        private System.Windows.Forms.TextBox txt_write;
        private System.Windows.Forms.TextBox txt_Append;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label label1;
    }
}

