using System;

namespace Exercise19
{
    class GeradorExtratos
    {
        public static void GerarExtrato(IConta c)
        {
            Console.WriteLine(c.getSaldo().ToString("F2"));
            
        }
    }
}
