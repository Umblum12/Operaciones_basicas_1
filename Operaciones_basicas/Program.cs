using System;

namespace Operaciones_basicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            decimal n1,n2,s,r,m;
            decimal di;
            string va;

            //Ingresar valores de variables
            Console.WriteLine("Ingrese el primer numero: ");
            va = Console.ReadLine();
            n1 = int.Parse(va);
            Console.WriteLine("Ingrese el segundo numero: ");
            va = Console.ReadLine();
            n2 = int.Parse(va);

            //Colocar el procedimiento
            s = n1 + n2;
            r = n1 - n2;
            m = n1 * n2;
            di= n1 / n2;

            //Imprimir en pantalla el resultado
            Console.WriteLine("El resultado de la suma es: " + s);
            Console.WriteLine("El resultado de la resta es: " + r);
            Console.WriteLine("El resultado de la multiplicación es: " + m);
            Console.WriteLine("El resultado de la división es: " + di);
            Console.ReadKey();


        }
    }
}
