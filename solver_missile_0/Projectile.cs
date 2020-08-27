using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Solver_missile_0
{
    public static class Physics
    {
        public static double Calc_X_Projectile_0(double t, double x_0, double v_0, double F_0, double m, double t_0)
        {
            return F_0 / (2 * m) * Math.Pow(t - t_0, 2) + v_0 * (t - t_0) + x_0;
        }
        public static double Calc_V_Projectile_0(double t, double v_0, double F_0, double m, double t_0)
        {
            return F_0 / m * (t - t_0) + v_0;
        }
    }
    public class Projectile
    {
        public Projectile(List<double> x_0, List<double> v_0, List<double> f_0, double m, double t_0)
        {
            X_0 = new List<double>(x_0);
            V_0 = new List<double>(v_0);
            F_0 = new List<double>(f_0);
            M = m;
            T_0 = t_0;
            x = new List<double>(X_0);
            v = new List<double>(V_0);
        }
        public Projectile()
        {
            X_0 = new List<double> { 0, 0, 0};
            V_0 = new List<double> { 0, 0, 0 };
            F_0 = new List<double> { 0, 0, 0 };
            M = 0;
            T_0 = 0;
            x = new List<double> { 0, 0, 0 };
            v = new List<double> { 0, 0, 0 };
        }

        private List<double> x;
        public List<double> X { get => x; }
        public void Calc_X(double t)
        {
            List<double> retval = new List<double> { 0, 0, 0};
            
            for (int i = 0; i < retval.Count; i++)
            {
                
                retval[i] = Physics.Calc_X_Projectile_0(t, X_0[i], V_0[i], M, F_0[i], T_0);
            }
            x = retval;
        }
        private List<double> v;
        public List<double> V { get => v; }
        public void Calc_V(double t)
        {
            List<double> retval = new List<double> { 0, 0, 0};
            for (int i = 0; i < retval.Count; i++)
            {
                retval[i] = Physics.Calc_V_Projectile_0(t, V_0[i], F_0[i], M, T_0);
            }
            v=retval;
        }
        public List<double> X_0 { get; set; }
        public List<double> V_0 { get; set; }
        public List<double> F_0 { get; set; }
        public double M { get; set; }
        public double T_0 { get; set; }
        public void Initialize()
        {
            x = X_0;
            v = V_0;
        }
    }
}
