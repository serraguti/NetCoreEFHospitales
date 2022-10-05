using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NetCoreEFHospitales.Data;
using NetCoreEFHospitales.Models;

namespace NetCoreEFHospitales.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }
    }
}
