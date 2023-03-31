using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    public interface IMatematik
    {
        float PI { get; set; }
        int Topla(int x, int y);
        double Kuvvet(double x, double y);
    }
}
