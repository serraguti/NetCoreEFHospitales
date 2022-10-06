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
    public partial class FormEliminarDoctor : Form
    {
        private RepositoryDoctores repo;

        public FormEliminarDoctor(RepositoryDoctores repo)
        {
            InitializeComponent();
            this.repo = repo;
            this.LoadDoctores();
        }

        //VAMOS A MOSTRAR TODOS LOS DOCTORES AL INICIAR
        //RECARGAREMOS LOS DOCTORES CUANDO PULSEMOS SOBRE ELIMINAR
        //NOS CREAMOS UN METODO PARA RECUPERAR LOS DOCTORES Y DIBUJARLOS
        private void LoadDoctores()
        {
            this.lstDoctores.Items.Clear();
            List<Doctor> doctores = this.repo.GetDoctores();
            foreach (Doctor doc in doctores)
            {
                string datos = doc.IdDoctor + " - "
                    + doc.Apellido + " - " + doc.Especialidad;
                this.lstDoctores.Items.Add(datos);
            }
        }

        private void btnEliminarDoctor_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL ID DOCTOR DE LA CAJA
            int idDoctor = int.Parse(this.txtIdDoctor.Text);
            //LLAMAMOS AL REPO PARA ELIMINAR
            this.repo.DeleteDoctor(idDoctor);
            //VOLVEMOS A CARGAR LOS DOCTORES
            this.LoadDoctores();
        }
    }
}
