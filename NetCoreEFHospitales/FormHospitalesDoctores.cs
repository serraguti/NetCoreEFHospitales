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
    public partial class FormHospitalesDoctores : Form
    {
        //ESTO SERA UN MAESTRO DETALLE QUE UTILIZARA HOSPITALES 
        //Y DOCTORES.  NECESITAMOS LOS DOS REPOSITORIOS
        private RepositoryHospital repoHospital;
        private RepositoryDoctores repoDoctores;
        //NECESITAMOS UNA COLECCION <int> PARA LOS IDs
        //DE LOS HOSPITALES
        private List<int> coleccionIdHospitales;

        public FormHospitalesDoctores
            (RepositoryHospital repohospital, RepositoryDoctores repodoctores)
        {
            InitializeComponent();
            this.repoHospital = repohospital;
            this.repoDoctores = repodoctores;
            this.coleccionIdHospitales = new List<int>();
            //CARGAMOS LOS HOSPITALES
            //EL CONTROL COMBOBOX DE FORMS NO CONTIENE VALUE, ES DECIR
            //SOLAMENTE PODEMOS RECUPERAR EL TEXTO.
            //NOSOTROS, EN ALGUN MOMENTO, NECESITAMOS EL CODIGO DEL HOSPITAL
            //CARGAREMOS LOS DATOS DE LOS NOMBRES DE HOSPITAL EN EL DIBUJO
            //Y, MEDIANTE UNA COLECCION, ALMACENAREMOS LOS DATOS DE LOS IDs.
            List<Hospital> hospitales = this.repoHospital.GetHospitales();
            foreach (Hospital h in hospitales)
            {
                //ALMACENAMOS EL NOMBRE DEL HOSPITAL
                string nombre = h.Nombre;
                //ALMACENAMOS EL IDHOSPITAL
                int idhospital = h.IdHospital;
                //AÑADIMOS EL ID A LA COLECCION EN MEMORIA
                this.coleccionIdHospitales.Add(idhospital);
                //AÑADIMOS EL NOMBRE AL DIBUJO
                this.cmbHospitales.Items.Add(nombre);
            }
        }

        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RECUPERAMOS EL INDICE DEL ELEMENTO SELECCIONADO
            //DENTRO DEL CONTROL COMBOBOX
            int indiceSeleccionado = this.cmbHospitales.SelectedIndex;
            //RECUPERAMOS EL IDHOSPITAL RESPECTO AL INDICE SELECCIONADO
            int idHospital = this.coleccionIdHospitales[indiceSeleccionado];
            List<Doctor> doctores = 
                this.repoDoctores.GetDoctoresHospital(idHospital);
            this.lsvDoctores.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                //CREAMOS UN NUEVO ELEMENTO ListViewItem
                ListViewItem it = new ListViewItem();
                //PRIMER ELEMENTO ES LA PROPIEDAD TEXT
                it.Text = doc.Apellido;
                //EL RESTO DE ELEMENTOS SON SUBITEMS
                //DE IZQUIERDA A DERECHA
                it.SubItems.Add(doc.Especialidad);
                it.SubItems.Add(doc.Salario.ToString());
                this.lsvDoctores.Items.Add(it);
            }
        }
    }
}
