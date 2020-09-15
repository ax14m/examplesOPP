using System;

namespace one_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           Console.WriteLine("Numero uno");
           int numuno = int.Parse(Console.ReadLine());

 Console.WriteLine("Numero dos");
           int numdos = int.Parse(Console.ReadLine());
            

            //forma estructurada
            //int suma  = numuno + numdos;
            //Console.WriteLine("El numero es: " + numuno);
            //Console.WriteLine($"la suma de:  {numuno} y  {numdos} es  {suma}" );
              //Console.WriteLine($"la suma de:  {numuno} y  {numdos} es  {numuno + numdos}" );
                
                //Forma orientada a Objetos
    //instanciar la clase operaciones objeto de la class operaciones
        //invocar la clase  class objeto(instancia) (= new) son palabras reservadas  constructor de la class()
   
   //Operaciones myOperacion = new Operaciones()
   var myOperacion = new Operaciones(){

       numerouno = numuno,
       numerodos = numdos
   };
//mostrar el valor
Console.WriteLine(myOperacion.numerouno);
    
    //llevar el valor como parametro  a un metodo
    //llamar el metodo de la clase mediante su instancia mediante un objeto

    myOperacion.imprimirSuma();

       
        }
    }

}
