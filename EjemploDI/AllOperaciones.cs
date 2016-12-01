using System.Collections.Generic;

namespace EjemploDI
{
    public class AllOperaciones : IAllOperacion
    {
        private readonly IEnumerable<IOperaciones> _operaciones;

        public AllOperaciones(IEnumerable<IOperaciones> operaciones)
        {
            _operaciones = operaciones;
        }

        public void Operar(string operador)
        {
            foreach (var operacion in _operaciones)
                operacion.Operar(operador);
        }
    }
}