﻿using System;

namespace EjemploDI
{
    public class Dividir : IOperaciones
    {
        public void Operar(string operador)
        {
            if (operador == "/")
            {
                var resultString = string.Format("{0}", 1 / 2);
                Console.WriteLine(resultString);
            }
        }
    }
}