using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Ejercio
{
    static class GestorBDD 
    {
        static OracleConnection con;
        static string cadenaConexion;
        
        
        static public OracleConnection Conexion()
        {
            
            cadenaConexion = @"DATA SOURCE = localhost:1521/xe; USER ID= BANCO_JOSH; password = 1122";
            con = new OracleConnection(cadenaConexion);

            return con;
        }

        static public void CrearConeccionf(string pOperacion )
        {
            OracleConnection C = GestorBDD.Conexion();
            C.Open();
            OracleCommand instruccion = C.CreateCommand();  
            instruccion.CommandText = pOperacion;
            instruccion.ExecuteNonQuery();
            C.Close();

            
        }

    }


}
