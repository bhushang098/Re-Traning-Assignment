namespace Fle_Create_Copy_Delete
{
    partial class FleMenuForm
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
            this.tb_createFile = new System.Windows.Forms.TextBox();
            this.tb_CopyFile = new System.Windows.Forms.TextBox();
            this.tb_Delete = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_createFile
            // 
            this.tb_createFile.Location = new System.Drawing.Point(75, 58);
            this.tb_createFile.Name = "tb_createFile";
            this.tb_createFile.Size = new System.Drawing.Size(100, 20);
            this.tb_createFile.TabIndex = 0;
            // 
            // tb_CopyFile
            // 
            this.tb_CopyFile.Location = new System.Drawing.Point(75, 154);
            this.tb_CopyFile.Name = "tb_CopyFile";
            this.tb_CopyFile.Size = new System.Drawing.Size(100, 20);
            this.tb_CopyFile.TabIndex = 1;
            this.tb_CopyFile.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_Delete
            // 
            this.tb_Delete.Location = new System.Drawing.Point(75, 251);
            this.tb_Delete.Name = "tb_Delete";
            this.tb_Delete.Size = new System.Drawing.Size(100, 20);
            this.tb_Delete.TabIndex = 2;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(476, 58);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(476, 147);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(476, 249);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FleName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FleName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FleName";
            // 
            // FleMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_Delete);
            this.Controls.Add(this.tb_CopyFile);
            this.Controls.Add(this.tb_createFile);
            this.Name = "FleMenuForm";
            this.Text = "Fle Operatons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_createFile;
        private System.Windows.Forms.TextBox tb_CopyFile;
        private System.Windows.Forms.TextBox tb_Delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

