using NetCoreEFHospitales.Models;
using NetCoreEFHospitales.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreEFHospitales
{
    public partial class Form1 : Form
    {
        private RepositoryHospital repo;

        public Form1(RepositoryHospital repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void btnCargarHospitales_Click(object sender, EventArgs e)
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lstHospitales.Items.Clear();
            foreach (Hospital h in hospitales)
            {
                string datos = h.IdHospital + " - " + h.Nombre
                    + " - " + h.Direccion + " - " + h.NumeroCamas;
                this.lstHospitales.Items.Add(datos);
            }
        }
    }
}
