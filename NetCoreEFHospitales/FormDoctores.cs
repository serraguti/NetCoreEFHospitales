using NetCoreEFHospitales.Models;
using NetCoreEFHospitales.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreEFHospitales
{
    public partial class FormDoctores : Form
    {
        private RepositoryDoctores repo;

        public FormDoctores(RepositoryDoctores repo)
        {
            InitializeComponent();
            this.repo = repo;
            List<Doctor> doctores = this.repo.GetDoctores();
            foreach (Doctor doc in doctores)
            {
                string datos = doc.Apellido + " - Salario: " + doc.Salario;
                this.lstDoctores.Items.Add(datos);
            }
        }

        private void btnBuscarDoctores_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.txtSalario.Text);
            List<Doctor> doctores = this.repo.GetDoctoresSalario(salario);
            this.lstDoctores.Items.Clear();
            if (doctores == null)
            {
                MessageBox.Show("No se han encontrado registros");
            }
            else
            {
                foreach (Doctor doc in doctores)
                {
                    string datos = doc.Apellido + " - Salario: " + doc.Salario;
                    this.lstDoctores.Items.Add(datos);
                }
            }
        }

        private void btnBuscarDoctor_Click(object sender, EventArgs e)
        {
            int idDoctor = int.Parse(this.txtIdDoctor.Text);
            Doctor doctor = this.repo.FindDoctor(idDoctor);
            this.lstDoctores.Items.Clear();
            if (doctor == null)
            {
                MessageBox.Show("Doctor no encontrado");
            }
            else
            {
                string datos = doctor.Apellido + " - " + doctor.Salario
                    + " - " + doctor.Especialidad;
                this.lstDoctores.Items.Add(datos);
            }
        }
    }
}
