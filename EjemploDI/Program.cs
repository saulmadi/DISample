using System;
using Autofac;

namespace EjemploDI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numero1 = 1;
            var numero2 = 2;

            var containerbuilder = new ContainerBuilder();

            containerbuilder.RegisterAssemblyTypes(typeof(AllOperaciones).Assembly)
                .AsImplementedInterfaces();

            var lifetTime = containerbuilder.Build();


            var operador = Console.ReadLine();


            var operacion = lifetTime.Resolve<IAllOperacion>();

            operacion.Operar(operador);


            Console.ReadKey();
        }
    }
}