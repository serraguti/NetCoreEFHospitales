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

        //METODO PARA BORRAR LAS CAJAS DE TEXTO AL REALIZAR
        //CONSULTAS DE ACCION
        private void DeleteData()
        {
            this.txtIdHospital.Text = "";
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCamas.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int idHospital = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            this.repo.InsertHospital(idHospital, nombre
                , direccion, telefono, camas);
            //BORRAMOS LAS CAJAS
            this.DeleteData(); 
            //CARGAMOS LOS HOSPITALES DE NUEVO
            this.LoadHospitales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS LOS DATOS DE LAS CAJAS
            int idHospital = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            //LLAMAMOS A LA BASE DE DATOS PARA LA ACCION
            this.repo.UpdateHospital(idHospital, nombre
                , direccion, telefono, camas);
            //BORRAMOS LAS CAJAS
            this.DeleteData();
            //RECARGAMOS LOS HOSPITALES DE LA BASE DE DATOS
            this.LoadHospitales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idHospital = int.Parse(this.txtIdHospital.Text);
            //LLAMAMOS A LA BASE DE DATOS PARA LA ACCION
            this.repo.DeleteHospital(idHospital);
            //BORRAMOS LAS CAJAS DE TEXTO
            this.DeleteData();
            //RECARGAMOS LOS HOSPITALES DE LA BASE DE DATOS
            this.LoadHospitales();
        }
    }
}
