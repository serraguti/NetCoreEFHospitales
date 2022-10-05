
namespace NetCoreEFHospitales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarHospitales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstHospitales = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargarHospitales
            // 
            this.btnCargarHospitales.Location = new System.Drawing.Point(31, 21);
            this.btnCargarHospitales.Name = "btnCargarHospitales";
            this.btnCargarHospitales.Size = new System.Drawing.Size(243, 50);
            this.btnCargarHospitales.TabIndex = 0;
            this.btnCargarHospitales.Text = "Cargar hospitales";
            this.btnCargarHospitales.UseVisualStyleBackColor = true;
            this.btnCargarHospitales.Click += new System.EventHandler(this.btnCargarHospitales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado Hospitales";
            // 
            // lstHospitales
            // 
            this.lstHospitales.FormattingEnabled = true;
            this.lstHospitales.ItemHeight = 30;
            this.lstHospitales.Location = new System.Drawing.Point(31, 139);
            this.lstHospitales.Name = "lstHospitales";
            this.lstHospitales.Size = new System.Drawing.Size(726, 274);
            this.lstHospitales.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 441);
            this.Controls.Add(this.lstHospitales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarHospitales);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarHospitales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstHospitales;
    }
}

