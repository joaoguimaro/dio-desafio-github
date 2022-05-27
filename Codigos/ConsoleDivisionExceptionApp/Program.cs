using System;

namespace ConsoleDivisionExceptionApp
{
    class Program
    {
        public static void Main()
        {
            int a = 100, b = 0;
            double resultado = 0;

            try{
            resultado = Dividir(a, b);
            Console.WriteLine("{0} dividido por {1} = {2}", a, b, resultado);
            }

            catch(DivideByZeroException ex) when (a < 0)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally{
                Console.WriteLine("Finalmente a divisão foi realizada!");
            }
        }

        static double Dividir(int x, int y)
        {
            if (y == 0)
            {
                throw new MyClassException("Minha mensagem customizada de erro!");
            }
            return (x / y);
        }
    }
}