using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            string nombre, fecha;
            int mes;

            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();

            Console.WriteLine("Ingrese los siguientes valores");
            Console.WriteLine("Saldo Inicial: ");

            saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Numero del mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fecha: ");
            fecha = Console.ReadLine();

            Console.WriteLine("\nResultado del sueldo {0}", conta.getSaldos(saldo));
            Console.WriteLine(conta.Saludos(nombre));
            Console.WriteLine(CapaLogica.Utilidades.getNombreDelMes(mes));

            Console.ReadKey();
        }
    }
}
