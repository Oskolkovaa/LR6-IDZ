using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_ИДЗ
{
    internal class GeometryIDZ<T> where T : Geometry
    {
        public static double GetPer(T geo)
        {
            return geo.GetPerimeter();
        }
    }
}
