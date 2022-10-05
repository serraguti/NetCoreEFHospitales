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
    public partial class FormDoctoresEspecialidad : Form
    {
        private RepositoryDoctores repo;

        public FormDoctoresEspecialidad(RepositoryDoctores repo)
        {
            InitializeComponent();
            this.repo = repo;
            //AL INICIAR LA APLICACION, QUEREMOS CARGAR TODAS LAS ESPECIALIDADES
            List<string> especialidades = this.repo.GetEspecialidades();
            foreach (string espe in especialidades)
            {
                this.cmbEspecialidades.Items.Add(espe);
            }
        }

        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string especialidad = this.cmbEspecialidades.SelectedItem.ToString();
            List<Doctor> doctores = this.repo.GetDoctoresEspecialidad(especialidad);
            this.lstDoctores.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                string datos = doc.Apellido + ", " + doc.Especialidad
                    + ", " + doc.Salario;
                this.lstDoctores.Items.Add(datos);
            }
        }
    }
}
