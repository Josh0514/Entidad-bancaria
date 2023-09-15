using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;



namespace Ejercio
{
    static class GestionDeDatos
    {
        static public List<Client> ConsultasC(string vOperacion)
        {

            Client cl;
            List<Client> vDatos = new List<Client>();
            OracleConnection c = GestorBDD.Conexion();
            c.Open();
            OracleDataReader datos;
            OracleCommand instruccion = c.CreateCommand();
            instruccion.CommandText = vOperacion;
            datos = instruccion.ExecuteReader();
            while (datos.Read())
            {
                cl = new Client();
                cl.Codigo = int.Parse(datos[0].ToString());
                cl.Nombres = datos[1].ToString();
                cl.Apellidos = datos[2].ToString();
                cl.DPI = int.Parse(datos[3].ToString());
                cl.TipoCuenta = (datos[4].ToString());
                cl.Fecha = datos[5].ToString();
                vDatos.Add(cl);
            }

            c.Close();
            return vDatos;
        }

        static public List<Productos> Consultam(string vOperacion)
        {

            Productos m;
            List<Productos> vDatosm = new List<Productos>();
            OracleConnection c = GestorBDD.Conexion();
            c.Open();
            OracleDataReader datos;
            OracleCommand instruccion = c.CreateCommand();
            instruccion.CommandText = vOperacion;
            datos = instruccion.ExecuteReader();
            while (datos.Read())
            {
                m = new Productos
                {
                    Codigo = int.Parse(datos[0].ToString()),
                    Nombres = datos[1].ToString(),
                    Apellidos = datos[2].ToString(),
                    DPI = int.Parse(datos[3].ToString()),
                    Precio = int.Parse(datos[4].ToString()),
                    Pagar = int.Parse(datos[5].ToString())
                };
                vDatosm.Add(m);
            }

            c.Close();
            return vDatosm;
        }

        static public List<Productos> ConsuM(string vOperacion)
        {
            Productos m;
            List<Productos> vdtt = new List<Productos>();
            OracleConnection c = GestorBDD.Conexion();
            c.Open();
            OracleDataReader datos;
            OracleCommand instruccion = c.CreateCommand();
            instruccion.CommandText = vOperacion;
            datos = instruccion.ExecuteReader();
            while (datos.Read())
            {
                m = new Productos
                {
                    Codigo = int.Parse(datos[0].ToString()),
                    Nombres = datos[1].ToString(),
                    Apellidos = datos[2].ToString(),
                    DPI = int.Parse(datos[3].ToString()),
                    Precio = int.Parse(datos[4].ToString()),
                    Pagar = int.Parse(datos[5].ToString())
                };

                vdtt.Add(m);
            }

            c.Close();
            return vdtt;

        }

        static public List<EstadoCuenta> ConsuE(string vOperacion)
        {
            EstadoCuenta e;
            List<EstadoCuenta> vdt = new List<EstadoCuenta>();
            OracleConnection c = GestorBDD.Conexion();
            c.Open();
            OracleDataReader datos;
            OracleCommand instruccion = c.CreateCommand();
            instruccion.CommandText = vOperacion;
            datos = instruccion.ExecuteReader();
            while (datos.Read())
            {
                e = new EstadoCuenta();
                e.Codigo = int.Parse(datos[0].ToString());
                e.Nombres = datos[1].ToString();
                e.Apellidos = datos[2].ToString();
                e.DPI = int.Parse(datos[3].ToString());
                e.Info = (datos[4].ToString());
                
                vdt.Add(e);
            }

            c.Close();
            return vdt;

        }

        

        static public Client Modificarf()
        {
            Client C = new Client();
            Console.WriteLine("Nombre de Futbolista: ");
            C.Nombres = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            C.Apellidos = Console.ReadLine();
            Console.WriteLine("Edad: ");
            C.DPI = int.Parse(Console.ReadLine());
            Console.WriteLine("Camisola: ");
            C.TipoCuenta = (Console.ReadLine());
            Console.WriteLine("Posicion: ");
            C.Fecha = Console.ReadLine();

            return C;
        }

        static public Productos ModificarM()
        {
            Productos m = new Productos();
            Console.WriteLine("Nombre Masajista: ");
            m.Nombres = Console.ReadLine();
            Console.WriteLine("Apellidos Masajista: ");
            m.Apellidos = Console.ReadLine();
            Console.WriteLine("Edad Masajista: ");
            m.DPI = int.Parse(Console.ReadLine());
            Console.WriteLine("Titulo Masajista: ");
            m.Precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Experiencia Masajista: ");
            m.Pagar = int.Parse(Console.ReadLine());

            return m;
        }

            static public EstadoCuenta Modif()
        {
            EstadoCuenta e = new EstadoCuenta();
            Console.WriteLine("Nombre de Entrenador: ");
            e.Nombres = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            e.Apellidos = Console.ReadLine();
            Console.WriteLine("Edad: ");
            e.DPI = int.Parse(Console.ReadLine());
            Console.WriteLine("Certificacion: ");
            e.Info = (Console.ReadLine());

            return e;

        }

        static public void ModificarCliente()
        {
            int vCod = 0;
            List<Client> cl = new List<Client>();
            cl = GestionDeDatos.ConsultasC("select * from futbolista order by codigo");
            foreach (var f1 in cl)
            {
                Console.WriteLine(f1.ToString());
            }

            Console.Write("Ingrese Codigo a Modificar: ");
            vCod = int.Parse(Console.ReadLine());
            Console.WriteLine(cl.Any(a => a.Codigo == vCod));
            if (cl.Any(a => a.Codigo == vCod))
            {
                Client f2 = cl.Find(a => a.Codigo == vCod);
                Console.WriteLine(f2.ToString());
                cl.Remove(f2);
                f2 = GestionDeDatos.Modificarf();
                f2.Codigo = vCod;
                cl.Add(f2);
                f2.ModificarBDD();
            }
            else
            {
                Console.WriteLine("No existe Codigo Ingresado");
                Console.ReadLine();
            }


        }

        static public void ModificaEstado()
        {
            int vC = 0;
            List<EstadoCuenta> e = new List<EstadoCuenta>();
            e = GestionDeDatos.ConsuE("select * from entrenador order by codigo");
            foreach(var e1 in e)
            {
                Console.WriteLine(e1.ToString());

            }

            Console.Write("Ingrese Codigo a Modificar");
            vC = int.Parse(Console.ReadLine());
            Console.WriteLine(e.Any(a => a.Codigo == vC));
            if( e.Any(a=> a.Codigo == vC))
            {
                EstadoCuenta e2 = e.Find(a => a.Codigo == vC);
                Console.WriteLine(e2.ToString());
                e.Remove(e2);
                e2 = GestionDeDatos.Modif();
                e2.Codigo = vC;
                e.Add(e2);
                e2.ModificareBDD();
            }
            else
            {
                Console.WriteLine("No existe Codigo Ingresado");
                Console.ReadLine();
            }
        }

        static public void ModificarProductos()
        {
            int vCodd = 0;
            List<Productos> m = new List<Productos>();
            m = GestionDeDatos.Consultam("select * from masajista order by codigo");
            foreach (var m1 in m)
            {
                Console.WriteLine(m1.ToString());
            }

            Console.Write("Ingrese Codigo a Modificar: ");
            vCodd = int.Parse(Console.ReadLine());
            Console.WriteLine(m.Any(a => a.Codigo == vCodd));
            if (m.Any(a => a.Codigo == vCodd))
            {
                Productos m2 = m.Find(a => a.Codigo == vCodd);
                Console.WriteLine(m2.ToString());
                m.Remove(m2);
                m2 = GestionDeDatos.ModificarM();
                m2.Codigo = vCodd;
                m.Add(m2);
                m2.ModificarmBDD();
            }
            else
            {
                Console.WriteLine("No existe Codigo Ingresado");
                Console.ReadLine();
            }


        }


        static public void EliminarCliente()
        {
            int vCodE = 0;
            List<Client> cl = new List<Client>();
            cl = GestionDeDatos.ConsultasC("select * from futbolista order by codigo");
            foreach(var f1 in cl)
            {
                Console.WriteLine(f1.ToString());

            }

            Console.Write("Ingrese codigo a Eliminar: ");
            vCodE = int.Parse(Console.ReadLine());
            Console.WriteLine(cl.Any(a => a.Codigo == vCodE));
            if(cl.Any(a=> a.Codigo == vCodE))
            {
                Client f2 = cl.Find(a => a.Codigo == vCodE);
                Console.WriteLine(f2.ToString());
                cl.Remove(f2);
                f2.EliminarBDD();


            }
            else
            {
                Console.WriteLine("No existe Codigo Ingresado");
                Console.ReadLine();
            }
               
        }

        static public void EliminarEstado()
        {
            int vCe = 0;
            List<EstadoCuenta> e = new List<EstadoCuenta>();
            e = GestionDeDatos.ConsuE("select * from entrenador order by codigo");
            foreach( var e1 in e)
            {
                Console.WriteLine(e1.ToString());
            }

            Console.Write("Ingrese Codigo a Eliminar");
            vCe = int.Parse(Console.ReadLine());
            Console.WriteLine(e.Any(a => a.Codigo == vCe));
            if (e.Any(a => a.Codigo == vCe))
            {
                EstadoCuenta e2 = e.Find(a => a.Codigo == vCe);
                Console.WriteLine(e2.ToString());
                e.Remove(e2);
                e2.EliminareBDD();
                
            }

        }

        static public void EliminarProductis()
        {
            int vCodM = 0;
            List<Productos> m = new List<Productos>();
            m = GestionDeDatos.Consultam("select * from futbolista order by codigo");
            foreach (var m1 in m)
            {
                Console.WriteLine(m1.ToString());

            }

            Console.Write("Ingrese codigo a Eliminar: ");
            vCodM = int.Parse(Console.ReadLine());
            Console.WriteLine(m.Any(a => a.Codigo == vCodM));
            if (m.Any(a => a.Codigo == vCodM))
            {
                Productos m2 = m.Find(a => a.Codigo == vCodM);
                Console.WriteLine(m2.ToString());
                m.Remove(m2);
                m2.EliminarmBDD();


            }
            else
            {
                Console.WriteLine("No existe Codigo Ingresado");
                Console.ReadLine();
            }

        }
    }
}
