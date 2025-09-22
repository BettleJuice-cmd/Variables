using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class Facultad
    {
        public String Nombre;
        public String Codigo;

        public String MostrarDatos()
        {
            return "Fcultad" + Nombre + ", Codigo" + Codigo;
        }




    }
}
