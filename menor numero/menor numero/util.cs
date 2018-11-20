using System;
using System.Collections.Generic;
using System.Text;

namespace menor_numero
{
    class util
    {

        public static int menorNumero( int a, int b, int c)
        {
            if (a<b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
