using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_ИДЗ
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeometryIDZ<Geometry>.GetPer(new Triangle(3,4,5)));
            Console.WriteLine(GeometryIDZ<Geometry>.GetPer(new Square(42)));
            Console.WriteLine(Arifmetic.Add(32, 42));
        }
    }
}
