using System.Net.Mail;
using System;
using System.Text.RegularExpressions;

namespace proyectDAN01
{
    class Program
    {
        /*El programa simula un registro para empresas en meses respectivos */
        static void Main(string[] args)
        {
            if (args.Length >= 1 )
            {
                //solicitra datos personales 
                Console.WriteLine("Inserte sus datos para el registro!");
            //nombre del cliente y almacenamiento de variable
            Console.Write("Nombre:");
            string name =Console.ReadLine();

            //apellido del cliente y almacenamiento de variable
            Console.Write("Apellido:");
            string last_name =Console.ReadLine();

            //edad del cliente y almacenamiento de variable
            Console.Write("Edad:");
            int age =Convert.ToInt32(Console.ReadLine());
            
                
           //cedula del cliente y almacenamiento de variable
            Console.Write("Cedula:");
            int id = Convert.ToInt32(Console.ReadLine());

            //correo del cliente y almacenamiento de variable
            Console.Write("Correo:");
            string MailAddress =Console.ReadLine();

            //texto final con el uso de los parametros primarios (almacenados en array) y datos almacenados en variables o 
            Console.WriteLine(name + " " +last_name + " su registro fue exitoso en el mes de "+args[0]+" en la empresa "+args[1]+" y su correo es '"+ MailAddress+"'. ");
                    Console.ReadKey();
            }
            else
            {
                //mensaje de precausion solicitando coregir datos primarios
                Console.WriteLine("**********PRECAUCIÓN**********");
                Console.WriteLine("por favor, ejecute de nuevo el programa y como parametros digite primero el nombre de la Empresa y luego el mes actual.");
                Console.ReadKey();
            }

        }

    }
}
