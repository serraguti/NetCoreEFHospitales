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

        //METODO PARA RECUPERAR EL HOSPITAL POR SU ID
        public Hospital FindHospital(int idHospital)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idHospital
                           select datos;
            return consulta.FirstOrDefault();
        }

        //METODO PARA ELIMINAR UN HOSPITAL POR SU ID
        public void DeleteHospital(int idHospital)
        {
            Hospital hospital = this.FindHospital(idHospital);
            this.context.Hospitales.Remove(hospital);
            this.context.SaveChanges();
        }

        //METODO PARA INSERTAR UN NUEVO HOSPITAL
        public void InsertHospital(int idHospital, string nombre
            , string direccion, string telefono, int camas)
        {
            //INSTANCIAMOS UNA NUEVA CLASE ENTITY
            Hospital hospital = new Hospital();
            //ASIGNAMOS SUS PROPIEDADES
            hospital.IdHospital = idHospital;
            hospital.Nombre = nombre;
            hospital.Direccion = direccion;
            hospital.Telefono = telefono;
            hospital.NumeroCamas = camas;
            //AGREGAMOS EL OBJETO SOBRE LA COLECCION DEL CONTEXT
            this.context.Hospitales.Add(hospital);
            //SALVAMOS CAMBIOS
            this.context.SaveChanges();
        }

        //METODO PARA MODIFICAR UN HOSPITAL POR SU ID
        public void UpdateHospital(int idHospital, string nombre
            , string direccion, string telefono, int camas)
        {
            //BUSCAMOS EL OBJETO/S QUE DESEAMOS MODIFICAR
            Hospital hospital = this.FindHospital(idHospital);
            //MODIFICAMOS SUS DATOS, PERO NO SE SUELE MODIFICAR
            //LA PRIMARY KEY DE UN OBJETO
            hospital.Nombre = nombre;
            hospital.Direccion = direccion;
            hospital.Telefono = telefono;
            hospital.NumeroCamas = camas;
            //NO EXISTE UN METODO PARA MODIFICAR LA COLECCION
            //UNA VEZ QUE EL OBJETO HA SIDO CAMBIADO, SIMPLEMENTE
            //SE ALMACENA EN BBDD
            this.context.SaveChanges();
        }
    }
}
