﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codigo_Eduardo_Camacho_Rivera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manejo de estructuras selectivas
            string nameUser, lastName, contactNumber, city, FBProfile, email;
            string user, password, passwordConfirm, codeAccess;
            byte age = 0;

            Console.WriteLine("Ingresa tu nombre y al finalizar presiona ENTER");
            nameUser = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido y al finalizar presiona ENTER");
            lastName = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad con digito y al finalizar presiona ENTER");
            age = Convert.ToByte(Console.ReadLine());

            //If
            if (age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("Completa tu registgro para obtener tu código de acceso");
                //Codigo para completar el perfil
                Console.WriteLine("Ingresa tu número de teléfono celular");
                contactNumber = Console.ReadLine();
                Console.WriteLine("Ingresa tu ciudad de residencia");
                city = Console.ReadLine();
                Console.WriteLine("Ingresa tu perfil de Facebook");
                FBProfile = Console.ReadLine();
                Console.WriteLine("Ingresa tu cuemta de email");
                email = Console.ReadLine();

                //Solictar credenciales de acceso
                Console.WriteLine("Ingresa tu nombre de usuario");
                user = Console.ReadLine();
                Console.WriteLine("Ingresa tu contraseña");
                password = Console.ReadLine();
                Console.WriteLine("Vuelve a ingresar tu contraseña");
                passwordConfirm = Console.ReadLine();

                if (password == passwordConfirm)
                {
                    //Numeros aletorios
                    Random rnd = new Random();
                    codeAccess = rnd.Next(1000, 9999).ToString();
                    Console.WriteLine("Código de acceso: {0}", codeAccess);
                }
            }
            else
            {
                Console.WriteLine("Solo pueden entrar mayores de edad");
            }








            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema....");
            Thread.Sleep(1000);
        }
    }
}
