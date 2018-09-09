using System;

namespace doblecontraseña
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string contraseña, contraseña1;

            Console.WriteLine("ingrese su contraseña: ");
            contraseña = Console.ReadLine();
            Console.WriteLine("Ingrese nuevamente su contraseña:");
            contraseña1 = Console.ReadLine();

            while (contraseña != contraseña1)
            {

                Console.WriteLine("Sus dos contraseñas no son iguales, intente nuevamente");
                Console.WriteLine("ingrese su contraseña: ");
                contraseña = Console.ReadLine();
                Console.WriteLine("Ingrese nuevamente su contraseña:");
                contraseña1 = Console.ReadLine();

            }
                                   
            Console.WriteLine("Su contaseña es correcta !bienvenido!!!!");


            Console.ReadKey();
        }
    }
}
