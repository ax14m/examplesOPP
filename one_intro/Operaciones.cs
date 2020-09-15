 using System;

namespace one_intro
{

class Operaciones

    {
        //atributos o propiedades
        public int numerouno { get; set; }
    // modificador de acceso  public -private get - set son metodos para recibir 
    //entregar valor de la propiedad

    public int numerodos { get; set; }

        //metodos o funciones
// mod acceseso y un tipo de retorno nombre metodo (args)
/*public void  NuestraSuma(int N1, int N2)
        {
int suma  = N1 + N2;
 Console.WriteLine($"la suma de:  {N1} y  {N2} es  {suma}" );
        } */
//separar responsabilidades en los metodos 

public int CalcularSuma (int n1 ,int n2) 
{
 int resultadoSuma = 0;
 
  resultadoSuma = n1 + n2;

  return resultadoSuma;

}

public void imprimirSuma(){

    Console.WriteLine( "la suma es" + CalcularSuma(numerouno ,numerodos));
}

    }

}