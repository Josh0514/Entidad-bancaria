using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio
{
    public abstract class Cliente
    {
        private int codigo;
        private string nombres;
        private string apellidos;
        private int dpi;

        // para get y set control+R+E; clase abstracta

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int DPI { get => dpi; set => dpi = value; }
    }
}
