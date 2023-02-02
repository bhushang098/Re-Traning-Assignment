namespace Serialiizaton_Example
{
    partial class SerializationMenu
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
            this.btn_binary_ser = new System.Windows.Forms.Button();
            this.btn_xml_ser = new System.Windows.Forms.Button();
            this.btn_xml_deser = new System.Windows.Forms.Button();
            this.btn_binary_deser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_binary_ser
            // 
            this.btn_binary_ser.Location = new System.Drawing.Point(109, 70);
            this.btn_binary_ser.Name = "btn_binary_ser";
            this.btn_binary_ser.Size = new System.Drawing.Size(112, 46);
            this.btn_binary_ser.TabIndex = 0;
            this.btn_binary_ser.Text = "Serialize Using Binary";
            this.btn_binary_ser.UseVisualStyleBackColor = true;
            this.btn_binary_ser.Click += new System.EventHandler(this.btn_binary_ser_Click);
            // 
            // btn_xml_ser
            // 
            this.btn_xml_ser.Location = new System.Drawing.Point(109, 241);
            this.btn_xml_ser.Name = "btn_xml_ser";
            this.btn_xml_ser.Size = new System.Drawing.Size(112, 51);
            this.btn_xml_ser.TabIndex = 1;
            this.btn_xml_ser.Text = "Serialize Using XML";
            this.btn_xml_ser.UseVisualStyleBackColor = true;
            this.btn_xml_ser.Click += new System.EventHandler(this.btn_xml_ser_Click);
            // 
            // btn_xml_deser
            // 
            this.btn_xml_deser.Location = new System.Drawing.Point(531, 241);
            this.btn_xml_deser.Name = "btn_xml_deser";
            this.btn_xml_deser.Size = new System.Drawing.Size(118, 51);
            this.btn_xml_deser.TabIndex = 2;
            this.btn_xml_deser.Text = "De-Serialize Using XML";
            this.btn_xml_deser.UseVisualStyleBackColor = true;
            this.btn_xml_deser.Click += new System.EventHandler(this.btn_xml_deser_Click);
            // 
            // btn_binary_deser
            // 
            this.btn_binary_deser.Location = new System.Drawing.Point(531, 62);
            this.btn_binary_deser.Name = "btn_binary_deser";
            this.btn_binary_deser.Size = new System.Drawing.Size(118, 54);
            this.btn_binary_deser.TabIndex = 3;
            this.btn_binary_deser.Text = "De-Serialize using Binary";
            this.btn_binary_deser.UseVisualStyleBackColor = true;
            this.btn_binary_deser.Click += new System.EventHandler(this.btn_binary_deser_Click);
            // 
            // SerializationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_binary_deser);
            this.Controls.Add(this.btn_xml_deser);
            this.Controls.Add(this.btn_xml_ser);
            this.Controls.Add(this.btn_binary_ser);
            this.Name = "SerializationMenu";
            this.Text = "SerialiZation Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_binary_ser;
        private System.Windows.Forms.Button btn_xml_ser;
        private System.Windows.Forms.Button btn_xml_deser;
        private System.Windows.Forms.Button btn_binary_deser;
    }
}

