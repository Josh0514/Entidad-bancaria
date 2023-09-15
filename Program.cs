using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Ejercio
{
    class Program
    {
        static void Main(string[] args)
        {
            int vMenu1 = 0;
            int vMenu2 = 0;

            List<Client> lClient = new List<Client>();
            List<EstadoCuenta> lentrenador = new List<EstadoCuenta>();
            List<Productos> lMasajista = new List<Productos>();



            while (vMenu1 != 4)
            {
                vMenu1 = GestorMenu.MenuNivel1();
                if (vMenu1 != 4) vMenu2 = GestorMenu.MenuNivel2();

                if (vMenu1 == 1) //Cliente
                {



                    if (vMenu2 == 1) //agregar
                        {
                            Client C = new Client();
                            Console.WriteLine("Codigo Banco: ");
                            C.Codigo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nombre Cliente: ");
                            C.Nombres = (Console.ReadLine());
                            Console.WriteLine("Apellidos Cliente: ");
                            C.Apellidos = (Console.ReadLine());
                            Console.WriteLine("DPI: ");
                            C.DPI = int.Parse(Console.ReadLine());
                            Console.WriteLine("Tipo de Cuenta: ");
                            C.TipoCuenta = (Console.ReadLine());
                            Console.WriteLine("Fecha: ");
                            C.Fecha = (Console.ReadLine());
                            lClient.Add(C);

                            C.AgregarBDD();

                        }

                        if (vMenu2 == 2) //listar
                        {
                            List<Client> cl = new List<Client>();
                            cl = GestionDeDatos.ConsultasC("select * from CLIENTE order by codigo");
                            foreach (var f1 in cl)
                            {
                                Console.WriteLine(f1.ToString());

                            }

                            Console.ReadLine();

                        }

                        if (vMenu2 == 3) //Modificar
                        {
                            GestionDeDatos.ModificarCliente();

                        }

                        if (vMenu2 == 4) //Eliminar
                        {
                            GestionDeDatos.EliminarCliente();
                        }
                    
                    

                }

                if (vMenu1 == 2) //ENTRENADOR
                {
                    if(vMenu2 == 1) //agregar.
                    {
                        EstadoCuenta e = new EstadoCuenta();
                        Console.WriteLine("Codigo de Cuenta: ");
                        e.Codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre de la Cuenta: ");
                        e.Nombres = (Console.ReadLine());
                        Console.WriteLine("Apellidos: ");
                        e.Apellidos = (Console.ReadLine());
                        Console.WriteLine("DPI: ");
                        e.DPI = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informacion de la cuenta: ");
                        e.Info = (Console.ReadLine());
                        
                        lentrenador.Add(e);

                        e.AgregarBDD();
                    }

                    if (vMenu2 == 2)//listar
                    {
                        List<EstadoCuenta> e = new List<EstadoCuenta>();
                        e = GestionDeDatos.ConsuE("select * ESTADO_CUENTA order by codigo");
                        foreach(var e1 in e)
                        {
                            Console.WriteLine(e1.ToString());
                        }

                        Console.ReadLine();
                    }

                    if (vMenu2 == 3)//modificar
                    {
                        GestionDeDatos.ModificaEstado();
                    }

                    if (vMenu2 == 4)//Eliminar
                    {
                        GestionDeDatos.EliminarEstado();
                    }
                }

                if (vMenu1 == 3) //Masajista
                {


                    if (vMenu2 == 1) //agregar
                    {
                        Productos m = new Productos();
                        Console.WriteLine("Codigo Producto: ");
                        m.Codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre Productos: ");
                        m.Nombres = (Console.ReadLine());
                        Console.WriteLine("Apellidos Masajista: ");
                        m.Apellidos = (Console.ReadLine());
                        Console.WriteLine("------------------------");
                        m.DPI = int.Parse(Console.ReadLine());
                        Console.WriteLine("DPI: ");
                        m.Precio= int.Parse(Console.ReadLine());
                        Console.WriteLine("Precio: ");
                        m.Pagar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pagar: ");
                        lMasajista.Add(m);

                        m.AgregarBDD();

                    }

                    if (vMenu2 == 2) //listar
                    {
                        List<Productos> m = new List<Productos>();
                        m = GestionDeDatos.ConsuM("select * from masajista order by codigo");
                        foreach (var m1 in m)
                        {
                            Console.WriteLine(m1.ToString());

                        }

                        Console.ReadLine();

                    }

                    if (vMenu2 == 3) //Modificar
                    {
                        GestionDeDatos.ModificarProductos();

                    }

                    if (vMenu2 == 4) //Eliminar
                    {
                        GestionDeDatos.EliminarProductis();
                    }
                }

            }

        }
    }
}
