namespace TypedUnTypedDataSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_display_typed = new System.Windows.Forms.Button();
            this.btn_display_untyped = new System.Windows.Forms.Button();
            this.btn_update_untyped = new System.Windows.Forms.Button();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(175, 56);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(156, 20);
            this.tb_name.TabIndex = 3;
            // 
            // btn_display_typed
            // 
            this.btn_display_typed.Location = new System.Drawing.Point(52, 258);
            this.btn_display_typed.Name = "btn_display_typed";
            this.btn_display_typed.Size = new System.Drawing.Size(119, 23);
            this.btn_display_typed.TabIndex = 6;
            this.btn_display_typed.Text = "Display Typed";
            this.btn_display_typed.UseVisualStyleBackColor = true;
            this.btn_display_typed.Click += new System.EventHandler(this.btn_display_typed_Click);
            // 
            // btn_display_untyped
            // 
            this.btn_display_untyped.Location = new System.Drawing.Point(267, 258);
            this.btn_display_untyped.Name = "btn_display_untyped";
            this.btn_display_untyped.Size = new System.Drawing.Size(121, 23);
            this.btn_display_untyped.TabIndex = 7;
            this.btn_display_untyped.Text = "Display UnTyped";
            this.btn_display_untyped.UseVisualStyleBackColor = true;
            this.btn_display_untyped.Click += new System.EventHandler(this.btn_display_untyped_Click);
            // 
            // btn_update_untyped
            // 
            this.btn_update_untyped.Location = new System.Drawing.Point(175, 371);
            this.btn_update_untyped.Name = "btn_update_untyped";
            this.btn_update_untyped.Size = new System.Drawing.Size(120, 43);
            this.btn_update_untyped.TabIndex = 8;
            this.btn_update_untyped.Text = "Update UnTyped";
            this.btn_update_untyped.UseVisualStyleBackColor = true;
            this.btn_update_untyped.Click += new System.EventHandler(this.btn_update_untyped_Click);
            // 
            // dgv_employee
            // 
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Location = new System.Drawing.Point(477, 83);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.Size = new System.Drawing.Size(240, 150);
            this.dgv_employee.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_employee);
            this.Controls.Add(this.btn_update_untyped);
            this.Controls.Add(this.btn_display_untyped);
            this.Controls.Add(this.btn_display_typed);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employye Types";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_display_typed;
        private System.Windows.Forms.Button btn_display_untyped;
        private System.Windows.Forms.Button btn_update_untyped;
        private System.Windows.Forms.DataGridView dgv_employee;
    }
}

