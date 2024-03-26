using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Material
    {
        protected string codigo; 
        protected string titulo; 
        public string Codigo {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public Material(string codigo,string titulo)
        {
            this.codigo = codigo;
            this.titulo = titulo;
        }
        //redefinición de métodos >> para imprimir datos por pantalla del objeto
        public override string ToString()
        {
            return "Código "+ codigo +" Título"+ titulo+"\n";
        }
    }
    
}
