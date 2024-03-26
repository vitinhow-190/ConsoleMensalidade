using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppMensalidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da anuidade: ");
            double anuidade = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Informe o valor da matricula: ");
            double matricula = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do material: ");
            double material = double.Parse(Console.ReadLine());

            int cont = 0;
           
            while (cont <= 12)  
            {
                double res = anuidade / 12 + matricula + material;
                
                matricula = 0;
               
                material = 0;
               
                Console.WriteLine("Mensalidade: " + cont + " valor: " + res.ToString("C"));
               
                cont++;
            }
            Console.ReadKey();


        }
    }
}
