using System;

namespace FuncionSenoidal
{
    class Program
    {
        static void Main(string[] args)
        {
            SeñalSenoidal señal = new SeñalSenoidal();

            señal.Amplitud = 5;
            //i +=1;
            //i = i+1;
            for(double i=0.0; i<=1; i+=0.05)
            {
                Console.WriteLine(señal.evaluar(i));
            }

            Console.ReadLine();
        }
    }
}
