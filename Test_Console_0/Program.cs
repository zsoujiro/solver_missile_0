using Solver_missile_0;
using System;
using System.Collections.Generic;

namespace Test_Console_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solver_missile_0.Projectile projectile = new Solver_missile_0.Projectile();
            projectile.F_0 = new List<double> { 1, 1, 1 };
            projectile.X_0= new List<double> { 2, 2, 2 };
            projectile.V_0 = new List<double> { 3, 3, 3 };
            projectile.M = 1;
            projectile.T_0 = 0;
            projectile.Initialize();
            projectile.Calc_X(5);
            projectile.Calc_V(5);
            Console.WriteLine($"x={projectile.X[2]}");
            Console.WriteLine($"v={projectile.V[2]}");
            for (int i=0; i<projectile.X.Count; i++)
            {
                Console.WriteLine($"{i}, {projectile.X[i]}, {projectile.V[i]}");
            }
        }
    }
}
