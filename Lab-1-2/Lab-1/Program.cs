using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 2, r = 5;
            double V;

            Cylinder.ClassInfo(); Console.WriteLine("\n");

            Cylinder cylinder1 = new Cylinder(2, 5);
            cylinder1.Print();
            Cylinder.СalculateVolume(ref h, ref r, out V);
            Console.WriteLine("Volume of cylinder: {0}", V);
            Console.WriteLine("Number of objects: {0}\n", Cylinder.NumberObjects());
            
           
            Cylinder cylinder2 = new Cylinder(7, 12);
            cylinder2.Print();
            Console.WriteLine("Number of objects: {0}\n", Cylinder.NumberObjects());
            if (cylinder1.Equals(cylinder2))
                Console.WriteLine("cylinder1 is equal cylinder2");
            else
                Console.WriteLine("cylinder1 is't equal cylinder2");

            if (MathObject.CylinderInBox(cylinder2, 8, 25, 28))
                Console.WriteLine("Can be placed it box");
            else
                Console.WriteLine("Can't be placed it box");

            MathObject.ReductionHeight(cylinder2);
            cylinder2.Print();

            Console.ReadKey();
        }
    }
}
