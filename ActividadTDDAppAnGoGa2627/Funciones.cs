using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDAppAnGoGa2627
{
    public class Funciones
    {       
        public static long calcularFactorialAnGoGa2627(int numero)
        {
            if (numero < 0)            
                return -1;            

            if (numero == 0)            
                return 1;
            
            long resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }


        public static bool esContrasenyaValidaAnGoGa2627(string contrasenya)
        {
            return contrasenya != null && contrasenya != "" && contrasenya.Length >= 8 && contrasenya.Contains("#");
        }

    }
}
