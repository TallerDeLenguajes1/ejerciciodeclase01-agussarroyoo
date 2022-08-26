using System;

namespace Problema03
{

    class Program
    {

        static void Main(string[] args)
        {
            Auto Auto2 = CrearAutoPeugeot(777);
            MostrarAuto(Auto2);
            Auto Auto1 = CrearAutoFiat();            
            MostrarAuto(Auto1);            

        }

        static Auto CrearAutoFiat(int? anio = null)
        {
            Auto auto = null;

            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Fiat"
                };
            }

            return auto;
        }

        static Auto CrearAutoPeugeot(int? anio = null)
        {
            Auto auto = null;
            
            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Peugeot"
                };
            }

            return auto;
        }

    
        static void MostrarAuto(Auto auto)
        {
            try
            {
                Console.WriteLine("{0} - {1}", auto.Modelo, auto.Anio);
                Console.ReadLine();
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("El auto no tiene año asignado");
            }
            
        }
    }
}
