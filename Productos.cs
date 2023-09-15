using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio
{
    public class Productos : Cliente
    {
        private int precio;
        private int pagar;

        public int Precio { get => precio; set => precio = value; }
        public int Pagar { get => pagar; set => pagar = value; }

        public void AgregarBDD()
        {
            string vInstruccion;

            vInstruccion = "INSERT INTO PRODUCTOS (ID_BANCO, NOMBRES, APELLIDOS, DPI, TIPO_CUENTA, FECHA)" +
             " VALUES(" + this.Codigo + ", '" + this.Nombres + "','" + this.Apellidos + "'," + this.DPI + ",'" + this.Precio + "','" + this.Pagar+ "')";

            GestorBDD.CrearConeccionf(vInstruccion);

        }

        public void ModificarmBDD()
        {
            string vInstruccion;

            vInstruccion = "update productos set " + "Nombres ='" + this.Nombres + "', apellidos = '" + this.Apellidos + "', edad = " + this.DPI +
                ", Titulo = '" + this.Precio+ "', Experiencia ='" + this.Pagar+ "'" +
                " where codigo = " + this.Codigo;
            GestorBDD.CrearConeccionf(vInstruccion);


        }

        public void EliminarmBDD()
        {
            string vInstruccion;
            vInstruccion = "delete productos where codigo= " + this.Codigo;
            GestorBDD.CrearConeccionf(vInstruccion);
        }

        public override string ToString()
        {
            return "  Codigo: " + this.Codigo +
                   ", Nombre: " + this.Nombres +
                   ", Apellido: " + this.Apellidos +
                   ", Edad: " + this.DPI +
                   ", Titulo: " + this.Precio+
                   ", Experiencia: " + this.Pagar;
        }


    }
}
