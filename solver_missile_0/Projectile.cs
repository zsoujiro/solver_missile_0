using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace solver_missile_0
{
    public class Projectile
    {
        public List<double> X_0 { get; set; }
        public List<double> V_0 { get; set; }
        public List<double> F_0 { get; set; }
        public List<double> X { get; }
        public List<double> V { get; set; }
        public double M { get; set; }
        public double T_0 { get; set; }
        public List<double> Calc_X(double t)
        {
            List<double> retval = new List<double>(3);
            for (int i = 0; i < retval.Count; i++)
            {
                retval[i] = F_0[i] / (2 * M) * Math.Pow(t - T_0, 2) + V_0[i]*(t - T_0) + X_0[i];
            }
            return retval;
        }
        public List<double> Calc_V(double t)
        {
            List<double> retval = new List<double>(3);
            for (int i = 0; i < retval.Count; i++)
            {
                retval[i] = F_0[i] / M * (t - T_0) + V_0[i];
            }
            return retval;
        }
    }
}
