﻿
namespace NetCoreEFHospitales
{
    partial class FormEliminarDoctor
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
            this.txtIdDoctor = new System.Windows.Forms.TextBox();
            this.btnEliminarDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDoctores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Doctor:";
            // 
            // txtIdDoctor
            // 
            this.txtIdDoctor.Location = new System.Drawing.Point(136, 27);
            this.txtIdDoctor.Name = "txtIdDoctor";
            this.txtIdDoctor.Size = new System.Drawing.Size(182, 35);
            this.txtIdDoctor.TabIndex = 1;
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.BackColor = System.Drawing.Color.Red;
            this.btnEliminarDoctor.Location = new System.Drawing.Point(345, 20);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Size = new System.Drawing.Size(186, 51);
            this.btnEliminarDoctor.TabIndex = 2;
            this.btnEliminarDoctor.Text = "Eliminar doctor";
            this.btnEliminarDoctor.UseVisualStyleBackColor = false;
            this.btnEliminarDoctor.Click += new System.EventHandler(this.btnEliminarDoctor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doctores";
            // 
            // lstDoctores
            // 
            this.lstDoctores.FormattingEnabled = true;
            this.lstDoctores.ItemHeight = 30;
            this.lstDoctores.Location = new System.Drawing.Point(12, 133);
            this.lstDoctores.Name = "lstDoctores";
            this.lstDoctores.Size = new System.Drawing.Size(519, 274);
            this.lstDoctores.TabIndex = 4;
            // 
            // FormEliminarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 433);
            this.Controls.Add(this.lstDoctores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarDoctor);
            this.Controls.Add(this.txtIdDoctor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormEliminarDoctor";
            this.Text = "FormEliminarDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDoctor;
        private System.Windows.Forms.Button btnEliminarDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDoctores;
    }
}