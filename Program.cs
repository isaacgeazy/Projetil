using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
           const double g = 9.80665;
           double ang, rad, vel, h, x;

           Console.Write(" VELOCIDADE ..:");
           vel = Convert.ToDouble(Console.ReadLine());

           Console.Write(" ÂNGULO..: ");
           ang = Convert.ToDouble(Console.ReadLine());

           rad = ang * (Math.PI / 180);
           x = Math.Pow(vel, 2) * Math.Sin(2 * rad) / g;
           h = Math.Pow((vel * Math.Sin(rad)), 2) / (2 * g);
           
           Console.WriteLine();

           Console.WriteLine($"Alcance máximo: {x:N2} m/s");
           Console.WriteLine($"Altura máxima: {h:N2} m/s");
        }
    }
}
