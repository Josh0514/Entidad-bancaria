using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio
{
    public class EstadoCuenta : Cliente
    {
        private  string info;

        public string Info { get => info; set => info = value; }

        public void AgregarBDD()
        {
            string vInstruccion;

            vInstruccion = "INSERT INTO ESTADO_CUENTA (CODIGO, NOMBRES, APELLIDOS, EDAD, CERTIFICACION)" +
             " VALUES(" + this.Codigo + ", '" + this.Nombres + "','" + this.Apellidos + "'," + this.DPI + ",'" + this.info + "')";

            GestorBDD.CrearConeccionf(vInstruccion);

        }

        public override string ToString()
        {
            return "  Codigo: " + this.Codigo +
                   ", Nombres: " + this.Nombres +
                   ", Apellidos: " + this.Apellidos +
                   ", Edad: " + this.DPI +
                   ", Certificacion: " + this.info;
        }

        public void ModificareBDD()
        {
            string vInstruccion;

            vInstruccion = "update estado_cuenta set " + "Nombres ='" + this.Nombres + "', apellidos = '" + this.Apellidos + "', edad = " + this.DPI +
                ", certificacion = " + this.info + 
                " where codigo = " + this.Codigo;
            GestorBDD.CrearConeccionf(vInstruccion);


        }

        public void EliminareBDD()
        {
            string vInstruccion;
            vInstruccion = "delete estado_cuenta where codigo= " + this.Codigo;
            GestorBDD.CrearConeccionf(vInstruccion);
        }



    }
}
