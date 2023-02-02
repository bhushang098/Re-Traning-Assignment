namespace Greetng_Form_HelloWorld
{
    partial class frmGreeting
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
            this.btn_hi = new System.Windows.Forms.Button();
            this.btn_hello = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_hi
            // 
            this.btn_hi.Location = new System.Drawing.Point(80, 244);
            this.btn_hi.Name = "btn_hi";
            this.btn_hi.Size = new System.Drawing.Size(87, 44);
            this.btn_hi.TabIndex = 0;
            this.btn_hi.Text = "Say HI";
            this.btn_hi.UseVisualStyleBackColor = true;
            this.btn_hi.Click += new System.EventHandler(this.btn_hi_Click);
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(404, 244);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(89, 41);
            this.btn_hello.TabIndex = 1;
            this.btn_hello.Text = "Say Hello";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(132, 144);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(89, 13);
            this.nameBox.TabIndex = 2;
            this.nameBox.Text = "Enter Name Here";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(308, 137);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(185, 20);
            this.tb_name.TabIndex = 3;
            this.tb_name.Text = "Your Name";
            // 
            // frmGreeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.btn_hello);
            this.Controls.Add(this.btn_hi);
            this.Name = "frmGreeting";
            this.Text = "Greetng Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hi;
        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.TextBox tb_name;
    }
}

