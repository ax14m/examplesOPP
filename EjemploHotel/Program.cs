using System;

namespace EjemploHotel
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Hotel WCG");
           

           Console.WriteLine("Cantidad de Huespedes");
           int huespedes = int.Parse(Console.ReadLine());
          
           Console.WriteLine("nombre habitacion");
           string nom_hab = Console.ReadLine();

           Console.WriteLine("Dias de estadia");
           int can_dias = int.Parse(Console.ReadLine());

           //instancia

           var hotelUno = new GestionHotel(){

               habitacion = nom_hab,
               huesped = huespedes,
               dias = can_dias
           };
    hotelUno.cuentaCobro();

        }
    }
}
    

