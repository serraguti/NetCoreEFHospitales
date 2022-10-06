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
    public partial class FormCrudHospitales : Form
    {
        private RepositoryHospital repo;

        public FormCrudHospitales(RepositoryHospital repo)
        {
            InitializeComponent();
            this.repo = repo;
            this.LoadHospitales();
        }

        //METODO PARA RELLENAR TODOS LOS HOSPITALES
        private void LoadHospitales()
        {
            this.lsvHospital.Items.Clear();
            List<Hospital> hospitales =
                this.repo.GetHospitales();
            foreach (Hospital hospital in hospitales)
            {
                ListViewItem it = new ListViewItem();
                it.Text = hospital.IdHospital.ToString();
                it.SubItems.Add(hospital.Nombre);
                it.SubItems.Add(hospital.Direccion);
                it.SubItems.Add(hospital.Telefono);
                it.SubItems.Add(hospital.NumeroCamas.ToString());
                this.lsvHospital.Items.Add(it);
            }
        }

        private void lsvHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SIEMPRE DEBEMOS PREGUNTAR SI TENEMOS ELEMENTOS
            //SELECCIONADOS
            if (this.lsvHospital.SelectedItems.Count != 0)
            {
                //RECUPERAMOS EL ID DEL HOSPITAL
                int idHospital =
                    int.Parse(this.lsvHospital.SelectedItems[0].Text);
                //BUSCAMOS EL HOSPITAL POR SU ID
                Hospital hospital = this.repo.FindHospital(idHospital);
                //DIBUJAMOS LOS DATOS DEL HOSPITAL
                this.txtIdHospital.Text = hospital.IdHospital.ToString();
                this.txtNombre.Text = hospital.Nombre;
                this.txtDireccion.Text = hospital.Direccion;
                this.txtTelefono.Text = hospital.Telefono;
                this.txtCamas.Text = hospital.NumeroCamas.ToString();
            }
        }
    }
}
