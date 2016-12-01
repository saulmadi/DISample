using System;

namespace EjemploDI
{
    public class Concatenar : IOperaciones
    {
        public void Operar(string operador)
        {
            if(operador == "p")
            {
                var resultString = string.Format("{0}{1}", 1 , 2);
                Console.WriteLine(resultString);
            }
        }
    }
}