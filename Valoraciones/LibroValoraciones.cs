using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {
        List<float> valoraciones = new List<float>();

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }
        public void AgregarValoraciones(float valoracion)
        {
            valoraciones.Add(valoracion);
        }
        

    }
}
