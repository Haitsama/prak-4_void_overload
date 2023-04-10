using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number numbers =new number();
            numbers.CariNilaiMin(25, 24);
            numbers.CariNilaiMin(25, 21,56);
            numbers.CariNilaiMax(25, 24);
            numbers.CariNilaiMax(25, 21, 26);
        }
    }
}
