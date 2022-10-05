
namespace NetCoreEFHospitales
{
    partial class FormDoctores
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnBuscarDoctores = new System.Windows.Forms.Button();
            this.lstDoctores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdDoctor = new System.Windows.Forms.TextBox();
            this.btnBuscarDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(248, 33);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(195, 35);
            this.txtSalario.TabIndex = 1;
            // 
            // btnBuscarDoctores
            // 
            this.btnBuscarDoctores.Location = new System.Drawing.Point(477, 33);
            this.btnBuscarDoctores.Name = "btnBuscarDoctores";
            this.btnBuscarDoctores.Size = new System.Drawing.Size(344, 48);
            this.btnBuscarDoctores.TabIndex = 2;
            this.btnBuscarDoctores.Text = "Buscar doctores";
            this.btnBuscarDoctores.UseVisualStyleBackColor = true;
            this.btnBuscarDoctores.Click += new System.EventHandler(this.btnBuscarDoctores_Click);
            // 
            // lstDoctores
            // 
            this.lstDoctores.FormattingEnabled = true;
            this.lstDoctores.ItemHeight = 30;
            this.lstDoctores.Location = new System.Drawing.Point(47, 159);
            this.lstDoctores.Name = "lstDoctores";
            this.lstDoctores.Size = new System.Drawing.Size(774, 304);
            this.lstDoctores.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Doctor:";
            // 
            // txtIdDoctor
            // 
            this.txtIdDoctor.Location = new System.Drawing.Point(158, 94);
            this.txtIdDoctor.Name = "txtIdDoctor";
            this.txtIdDoctor.Size = new System.Drawing.Size(100, 35);
            this.txtIdDoctor.TabIndex = 5;
            // 
            // btnBuscarDoctor
            // 
            this.btnBuscarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarDoctor.Location = new System.Drawing.Point(279, 83);
            this.btnBuscarDoctor.Name = "btnBuscarDoctor";
            this.btnBuscarDoctor.Size = new System.Drawing.Size(164, 59);
            this.btnBuscarDoctor.TabIndex = 6;
            this.btnBuscarDoctor.Text = "Buscar doctor";
            this.btnBuscarDoctor.UseVisualStyleBackColor = false;
            this.btnBuscarDoctor.Click += new System.EventHandler(this.btnBuscarDoctor_Click);
            // 
            // FormDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 490);
            this.Controls.Add(this.btnBuscarDoctor);
            this.Controls.Add(this.txtIdDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDoctores);
            this.Controls.Add(this.btnBuscarDoctores);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormDoctores";
            this.Text = "FormDoctores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnBuscarDoctores;
        private System.Windows.Forms.ListBox lstDoctores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdDoctor;
        private System.Windows.Forms.Button btnBuscarDoctor;
    }
}