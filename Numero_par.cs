using System;
namespace Aporte_CalderonByron3A_Ej1
{
    class Numero_par
    {
        public void Pedir_num()
        {
            Console.WriteLine("Ingresa el número para verificar: ");
            double numero= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Elegir_num(numero);
        }

        public void Elegir_num(double numero)
        {
            if(numero % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par -> "+numero);
            }
            else
            {
                Console.WriteLine("El número ingresado es impar -> "+numero);
            }
        }
    }
}