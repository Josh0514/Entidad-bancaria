using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace Ejercio
{
    public class Client : Cliente
    {
        private string tipocuenta;
        private string fecha;

       

        public string TipoCuenta { get => tipocuenta; set => tipocuenta = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public void AgregarBDD()
        {
            string vInstruccion;
             
            vInstruccion= "INSERT INTO CLIENTE (CODIGO, NOMBRES, APELLIDOS, DPI, TIPO_CUENTA, FECHA)" +
             " VALUES("+ this.Codigo+", '"+this.Nombres+"','"+this.Apellidos+"',"+this.DPI+","+this.TipoCuenta+",'"+this.Fecha+"')";

            GestorBDD.CrearConeccionf(vInstruccion);
            
        }

        public void ModificarBDD()
        {
            string vInstruccion;

            vInstruccion = "update cliente set " + "Nombres ='" + this.Nombres + "', apellidos = '" + this.Apellidos + "', dpi = " + this.DPI +
                ", Tipo de Cuenta = " + this.TipoCuenta + ", Fecha ='" + this.Fecha + "'" +
                " where codigo = " + this.Codigo;
            GestorBDD.CrearConeccionf(vInstruccion);
         

        }

        public void EliminarBDD()
        {
            string vInstruccion;
            vInstruccion = "delete cliente where codigo= " + this.Codigo;
            GestorBDD.CrearConeccionf(vInstruccion);
        }

        public override string ToString()
        {
            return "  Codigo: " + this.Codigo +
                   ", Nombre: " + this.Nombres +
                   ", Apellido: " + this.Apellidos +
                   ", DPI: " + this.DPI +
                   ", Tipo de Cuenta: " + this.TipoCuenta +
                   ", Fecha: " + this.Fecha;
        }

        
    }
}
