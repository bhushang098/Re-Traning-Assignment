namespace task1
{
    partial class frm_employee
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_show_department = new System.Windows.Forms.Button();
            this.emp_details = new System.Windows.Forms.Label();
            this.lbl_emp_department = new System.Windows.Forms.Label();
            this.lbl_salary_department = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(109, 202);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(72, 24);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_show_department
            // 
            this.btn_show_department.Location = new System.Drawing.Point(88, 273);
            this.btn_show_department.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_show_department.Name = "btn_show_department";
            this.btn_show_department.Size = new System.Drawing.Size(119, 28);
            this.btn_show_department.TabIndex = 1;
            this.btn_show_department.Text = "Show Departments";
            this.btn_show_department.UseVisualStyleBackColor = true;
            this.btn_show_department.Click += new System.EventHandler(this.btn_show_department_Click);
            // 
            // emp_details
            // 
            this.emp_details.AutoSize = true;
            this.emp_details.Location = new System.Drawing.Point(95, 33);
            this.emp_details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emp_details.Name = "emp_details";
            this.emp_details.Size = new System.Drawing.Size(88, 13);
            this.emp_details.TabIndex = 2;
            this.emp_details.Text = "Employee Details";
            // 
            // lbl_emp_department
            // 
            this.lbl_emp_department.AutoSize = true;
            this.lbl_emp_department.Location = new System.Drawing.Point(70, 67);
            this.lbl_emp_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_emp_department.Name = "lbl_emp_department";
            this.lbl_emp_department.Size = new System.Drawing.Size(145, 13);
            this.lbl_emp_department.TabIndex = 3;
            this.lbl_emp_department.Text = "total Employee in Department";
            // 
            // lbl_salary_department
            // 
            this.lbl_salary_department.AutoSize = true;
            this.lbl_salary_department.Location = new System.Drawing.Point(70, 113);
            this.lbl_salary_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_salary_department.Name = "lbl_salary_department";
            this.lbl_salary_department.Size = new System.Drawing.Size(132, 13);
            this.lbl_salary_department.TabIndex = 4;
            this.lbl_salary_department.Text = "Total Salary in Department";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(512, 19);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(278, 131);
            this.dgvEmployees.TabIndex = 5;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(512, 193);
            this.dgvDepartments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.Size = new System.Drawing.Size(253, 131);
            this.dgvDepartments.TabIndex = 6;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellContentClick);
            this.dgvDepartments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dept_row_header_clicked);
            // 
            // frm_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 434);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.lbl_salary_department);
            this.Controls.Add(this.lbl_emp_department);
            this.Controls.Add(this.emp_details);
            this.Controls.Add(this.btn_show_department);
            this.Controls.Add(this.btn_exit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_employee";
            this.Text = "Employee Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_show_department;
        private System.Windows.Forms.Label emp_details;
        private System.Windows.Forms.Label lbl_emp_department;
        private System.Windows.Forms.Label lbl_salary_department;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridView dgvDepartments;
    }
}

