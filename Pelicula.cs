using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Pelicula: Material
    {
        protected int anyoEstreno;
        protected string director;
        public int AnyoEstreno {
            get { return anyoEstreno; }
            set { anyoEstreno = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public Pelicula(int anyoEstreno,string director,string codigo,string titulo)
            :base(codigo,titulo)
        {
            this.anyoEstreno = anyoEstreno;
            this.director = director;
        }
        public override string ToString()
        {
            return "Película:\n" + base.ToString() + " Estreno: " + anyoEstreno +
                " Director: " + director + "\n";
        }
    }
}
