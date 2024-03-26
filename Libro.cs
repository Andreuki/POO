using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Libro: Material
    {
        protected int numPaginas;
        //Propiedades get/set
        public int NumPaginas
        {
            get { return numPaginas; }
            set {
                if (value > 0)
                {
                    numPaginas = value;
                }
                else {
                    numPaginas = 0;
                }
                
            }
        }
        //constructor apoyado en el padre
        public Libro(string codigo,string titulo,int numPaginas):base(codigo,titulo)
        {
            this.numPaginas = numPaginas;
        }
        //Volvemos a redefinir de la clase material 
        public override string ToString()
        {
            return "Libro: \n"+ base.ToString() + " Num.páginas: " + numPaginas + "\n"; 
        }
    }
}
