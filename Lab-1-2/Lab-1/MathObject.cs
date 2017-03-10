using System;

namespace Lab_1
{
    static class MathObject
    {
        public static void ReductionHeight(Cylinder obj)
        {
            if(obj.Height > 1)
                obj.Height--;
            else
                Console.WriteLine("Wrong parameter: Height. Сan't do the operation");
        }
        public static bool CylinderInBox(Cylinder obj, double height, double width, double length)
        {
            return obj.Height <= height && obj.Radius*2 <= width && obj.Radius*2 <= length;
        }
    }
}
