using System;

using System.Collections.Generic;

using System.Diagnostics.Tracing;

using System.Runtime.CompilerServices;

using System.Text;



namespace Trabajo

{

    abstract class Vehiculo : VehiculoComponente

    {





    }

    abstract class VehiculoComponente

    {

        public abstract int Estadocomponente(int a);





    }

    class Automovil : Vehiculo

    {

        public override int Estadocomponente(int a)

        {

            return 100;

        }

        public string Marca(string marca)

        {



            return "La marca del vehiculo es : " + marca;

        }

        public string T(int T)

        {

            return "El año del vehiculo corresponde a : " + T;

        }

        public string Kilometraje(int kilometraje)

        {

            return "El kilometraje del vehiculo : " + kilometraje + " KMs.";

        }



    }
    class Estanque : VehiculoComponente

    {
        public override int Estadocomponente(int a)

        {
            return 25;
        }
        public string Capacidad(int capa)

        { 
            return "La capacidad del vehiculo es : " + capa + " Litros.";

        }
        private readonly int capac;
        public string Cantidad(int cantidad)

        {
            if (cantidad >= (capac / 10))

            {
                return "El estanque tiene media capacidad ";

            }
            else
                return "El estanque tiene una capacidad baja ";

        }

    }
    class Mezclador : VehiculoComponente

    {
        public override int Estadocomponente(int a)

        {
            return 70;
        }
        public string Mezcla(int mezclador)

        {
            if (mezclador == 1)

            {
                return "El tipo de mezclador del vehiculo es : Carburador!";
            }
            else
                return "El tipo de mezclador del vehiculo es  : Inyector!";
        }

    }
    class Rueda : VehiculoComponente
    {
        public override int Estadocomponente(int a)

        {
            return 68;
        }
        public string Recubrimiento(int recubrimiento)

        {
            if (recubrimiento == 1)
            {
                return "El recubrimiento opcionado es : hule!";
            }
            else if (recubrimiento == 2)
            {
                return "El recubrimiento opcionado es : fenol!";
            }
            else
                return "El recubrimiento opcionado es : Poliuretano!";
        }
        public string Durometro(int nm1, int nm2)

        {
            return " indice del durometro es : " + (nm1, + nm2);
        }

    }

    class Motor : VehiculoComponente

    {
        public override int Estadocomponente(int a)

        {
            return 80;
        }
        public string Id(int id)

        {
            return "La ID del vehiculo es: " + id;
        }
        public string Tipo(int tipo)

        {
            if (tipo == 1)

            {
                return "El motro de este vehiculo es de :  Dos-tiempos ! ";
            }
            else

                return "El motor de este vehiculo es de : Cuatro-tiempos ! ";

        }



    }

}