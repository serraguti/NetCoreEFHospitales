using NetCoreEFHospitales.Data;
using NetCoreEFHospitales.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NetCoreEFHospitales.Repositories
{
    public class RepositoryDoctores
    {
        private HospitalContext context;

        public RepositoryDoctores(HospitalContext context)
        {
            this.context = context;
        }

        //METODO PARA DEVOLVER TODOS LOS EMPLEADOS DE LOS DOCTORES
        public List<Doctor> GetDoctores()
        {
            var consulta = from datos in this.context.Doctores
                           select datos;
            return consulta.ToList();
        }

        //METODO PARA MOSTRAR LOS DOCTORES POR SU SALARIO
        public List<Doctor> GetDoctoresSalario(int salario)
        {
            var consulta = from datos in this.context.Doctores
                           where datos.Salario >= salario
                           select datos;
            //COMPRAMOS SI HEMOS RECIBIDO DOCTORES
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.ToList();
            }
        }

        public Doctor FindDoctor(int idDoctor)
        {
            //EN LA BUSQUEDA, NO SE SABE SI BUSCAMOS UNO O VARIOS
            //ESO SOLAMENTE LO SABEMOS NOSOTROS.
            var doctor = (from datos in this.context.Doctores
                          where datos.IdDoctor == idDoctor
                          select datos).FirstOrDefault();
            //AHORA ESTARA DEVOLVIENDO UN NULL O UN OBJETO DOCTOR
            return doctor;
        }

        //METODO PARA DEVOLVER LAS ESPECIALIDADES
        public List<string> GetEspecialidades()
        {
            var consulta = (from datos in context.Doctores
                           select datos.Especialidad).Distinct();
            return consulta.ToList();
        }

        //METODO PARA MOSTRAR LOS DOCTORES SEGUN SU ESPECIALIDAD
        public List<Doctor> GetDoctoresEspecialidad(string especialidad)
        {
            var consulta = from datos in context.Doctores
                           where datos.Especialidad == especialidad
                           select datos;
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.ToList();
            }
        }
    }
}
