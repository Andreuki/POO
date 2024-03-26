using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Usuario
    {
        protected string dni;
        protected string nombre;
        protected string direccion;
        protected string telefono;
        protected bool sancionesPendientes;

        //Propiedades en vez de getters y setters tradicionales
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public bool  SancionesPendientes
        {
            get { return sancionesPendientes; }
            set { sancionesPendientes = value; }
        }
        //Constructor de la clase

        public Usuario(string dni,string nombre, string direccion, string telefono,
            bool sancionesPendientes) {

            this.dni = dni;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.sancionesPendientes = sancionesPendientes;
        }

    }
}
