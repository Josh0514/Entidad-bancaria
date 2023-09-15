using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio
{
    static class GestorMenu
    {
        static public int MenuNivel1()
        {
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MENU PRINCIPAL \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. CLIENTE");
            Console.WriteLine("2. PRODUCTO");
            Console.WriteLine("3. ESTADO DE CUENTA");
            Console.WriteLine("4. SALIR");
            Console.WriteLine("Elija una opcion: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;

        }

        static public int MenuNivel2()
        {
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("SUB-MENU PRINCIPAL");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. AGREGAR");
            Console.WriteLine("2. LISTAR");
            Console.WriteLine("3. MODIFICAR");
            Console.WriteLine("4. ELIMINAR");
            Console.WriteLine("5. SALIR");
            Console.WriteLine("6. VER ESTADO DE CUENTA");
            Console.WriteLine("Elija una opcion");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------");
            int opcion = int.Parse(Console.ReadLine());

            return opcion; 

        }
    }
}
