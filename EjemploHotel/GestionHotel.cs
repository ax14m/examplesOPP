using System;

namespace EjemploHotel{

    class GestionHotel 
    {
        //propiedades

        public string habitacion {get; set; }
          public string huesped {get; set; }
            public string dias {get; set; }

            //metodos

            public int valorEstadia(int huesp, int cantd){
                int TINDIVIDUAL = 2500;
                int TDOBLE = 4600;
                int TFAMILIAR = 5200;
                
                int cobro = 0;
                if (huesp == 1) {
                    cobro = cantd * TINDIVIDUAL;

                }
                else {  
                    if (huesp== 2) {
                        cobro = cantd * TDOBLE;    
                    }
                else {
                    if (huesp >=3) {
                        cobro = cantd * TFAMILIAR;
                    } else {

                    }
                }  
               
           }
                    
             return cobro;  

                public void cuentaCobro(){
                    int IVA = 19;
                    int precioConiva = 0;
                    int precioSiniva = 0;
                     precioSiniva = valorEstadia(huesp, dias);

                     precioConiva = ((precioSiniva * IVA) / 100) + precioSiniva;

                     Console.WriteLine(precioConiva);

                }

            }


    }


}