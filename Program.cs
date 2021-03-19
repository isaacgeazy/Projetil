using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
           const double g = 9.80665;
           double ang;
           double vel;
           double rad;
           double h;
           double x;

           Console.WriteLine("---Projétil---");

           Console.Write("Entre com a velocidade, em m/s ..:");
           vel = Convert.ToDouble(Console.ReadLine());

           Console.Write("Entre com ÂNGULO..: ");
           ang = Convert.ToDouble(Console.ReadLine());

           rad = ang * (Math.PI / 180);

           x = Math.Pow(vel, 2) * Math.Sin(2 * rad) / g;
           Console.WriteLine($"Alcance maximo ..: {x:N2} m/s");

           h = Math.Pow((vel * Math.Sin(rad)), 2) / (2 * g);
           Console.WriteLine($"Altura maxima ..: {h:N2} m/s");


        }
    }
}
