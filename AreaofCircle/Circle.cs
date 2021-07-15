using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofCircle
{
    public class Circle
    {
 
        public static double areaMethod(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double circumferenceMethod(double radius)
        {
            return Math.PI * 2 * radius;
        }
    }
    
}
