using System;



namespace Trabajo

{

    class Program

    {
        private static int sesion;
        static void Main(string[] args)

        { 
            const string usuario = "admin";

            const string contraseña = "abc123";

            Console.WriteLine("Introduzca su nombre de Usuario ! : ");

            string nombre = Console.ReadLine();

            Console.WriteLine("Introduzca su  contraseña de usuario ! : ");

            string codigo = Console.ReadLine();

            int cotinue = 0;

            while (nombre != usuario || codigo != contraseña)

            {
                cotinue++;

                if (nombre != usuario || codigo != contraseña)

                {
                    Console.WriteLine("El Usuario o la  contraseña es incorrecto.Por favor intente otra vez. ");

                    Console.WriteLine("Introduzca su nombre de Usuario ! : ");

                    nombre = Console.ReadLine();

                    Console.WriteLine("Introduzca su  contraseña de usuario ! : ");

                    codigo = Console.ReadLine();
                }

                else
                {
                    ;
                }
            }
            do
            {
                object[,] Informacion = Lista();

                static object[,] Lista()

                {
                    Console.WriteLine("Cuanto vehiculos se  desea almacenar? : ");

                    string rpt = Console.ReadLine();

                    int CantidadVehiculos = int.Parse (rpt);

                    object[,] datos = new object[CantidadVehiculos, 15];

                    for (int i = 0; i < CantidadVehiculos; i++)
                    {
                        Automovil auto;

                        auto = new Automovil();

                       

                        Console.WriteLine("Marca del Vehiculo: ");

                        string marca = Console.ReadLine();

                        datos[i, 1] = auto.Marca(marca);                    

                        Console.WriteLine(" indique Año del Vehiculo: ");

                        int T= int.Parse(Console.ReadLine());
                        
                        datos[i, 2] = auto.T (T);                      

                        Console.WriteLine("indique kilometraje del vehiculo: ");

                        int kilometraje = int.Parse(Console.ReadLine());

                        datos[i, 3] = auto.Kilometraje(kilometraje);

                        Estanque estanque;

                        estanque = new Estanque();

                        

                        Console.WriteLine("Capacidad del estanque del vehiculo: ");

                        int capa = int.Parse(Console.ReadLine());

                        datos[i, 5] = estanque.Capacidad(capa);

                        Console.WriteLine("Cantidad de combustible: ");

                        int cantidad = int.Parse(Console.ReadLine());

                        datos[i, 6] = estanque.Cantidad(cantidad);
                        Mezclador mesclador;

                        mesclador = new Mezclador();

                       
                        Console.WriteLine("que tipo de mezclador es: 1.-Carburador 2.-Inyector");

                        int mezclador = int.Parse(Console.ReadLine());
                       

                        datos[i, 8] = mesclador.Mezcla(mezclador);
                        datos[i, 7] = mesclador.Estadocomponente(50) + "% " + "de estado.";
                        Rueda rueda;

                        rueda = new Rueda();

                        

                        Console.WriteLine("que tipo de recubridor es? : 1.-Fenol 2.-Hule 3.-Poliuretano");

                        int recubrimiento = int.Parse(Console.ReadLine());

                        datos[i, 10] = rueda.Recubrimiento(recubrimiento);
                        datos[i, 9] = rueda.Estadocomponente(60) + "% " + "de estado.";
                        Console.WriteLine("Indique el valor de dureza de la rueda? :");

                        Console.WriteLine("ejemplo 100 y 180");
                        Console.WriteLine("el primer numero no debe ser mayor al segundo");

                        Console.WriteLine(" valor 1 :");

                        int nm1 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" valor 2 :");

                        int nm2= int.Parse(Console.ReadLine());

                        datos[i, 11] = rueda.Durometro(nm1, nm2);

                        Motor motor;

                        motor = new Motor();

                        Console.WriteLine(" Numero ID del vehiculo? :");

                        int id = int.Parse(Console.ReadLine());

                        datos[i, 12] = motor.Id(id);

                        Console.WriteLine("que tipo de motor es su vehiculo ? : 1.-Dos-tiempos 2.-Cuatro-tiempos");

                        int tipo = int.Parse(Console.ReadLine());

                        datos[i, 13] = motor.Tipo(tipo);

                        datos[i, 14] = motor.Estadocomponente(70) + "% " + "de estado.";


                    }

                    return datos;

                }
                Console.WriteLine("Desea ver la informacion del vehiculo? . 1.-si   2.-no");

                int respuesta = int.Parse(Console.ReadLine());

                if (respuesta == 1)

                {
                    Console.WriteLine("informacion del Vehiculo:  ");

                    foreach (object i in Informacion)

                    {
                        Console.WriteLine("> " + i);

                    }

                }

                else

                {
                }
                Console.WriteLine("quiere cerrar sesion? : marque 1.-si  2.-no");

                int sesion = int.Parse(Console.ReadLine());

                if (sesion == 1)

                {
                    Console.WriteLine("finalizado");
                    break;
                }
                else
                {
                    ;
                }
            } while (sesion != 1);



        }

    }

}

