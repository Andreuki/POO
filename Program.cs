using System;

namespace biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usu1 = new Usuario("48765493D","Andrea Peñalver","C/ del aburrimiento",
                "665 487 936",false);
            Console.WriteLine("Usuario creado con el nombre {0} \n",usu1.Nombre);
            Material[] materiales = new Material[5];
            materiales[0] = new Libro("1-104", "La red púrpura", 400);
            materiales[1] = new Pelicula(1994,"tarantino","40569","Kill Bill");
            materiales[2] = new Libro("2-206","La novia gitana",380);
            materiales[3] = new Pelicula(2001,"Anónimo","50320","Odisea en el lodo");
            materiales[4] = new Libro("3-507","La nena",360);
            foreach (Material m in materiales) {
                Console.WriteLine(m);
            }
        }
    }
}
