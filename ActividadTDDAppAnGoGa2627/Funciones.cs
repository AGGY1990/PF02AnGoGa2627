using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDAppAnGoGa2627
{
    public class Funciones
    {       
        public static long calcularFactorialAnGoGa2627(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            if (n == 0)
            {
                return 1;
            }

            long resultado = 1;

            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
        
    }
}
