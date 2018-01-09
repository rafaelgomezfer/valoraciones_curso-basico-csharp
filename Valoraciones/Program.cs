using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroValoraciones libro =new LibroValoraciones();
            libro.AgregarValoraciones(3.5f);
            libro.AgregarValoraciones(5);
        }
    }
}
