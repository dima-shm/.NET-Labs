using System;

namespace Lab_1
{
    class Cylinder
    {
        private int height;
        private int radius;
        private readonly int ID;
        private const double PI = 3.1415;
        private static int numObj;

        public Cylinder()
        {
            height = 0;
            radius = 0;
            ID = Height.GetHashCode() + Radius.GetHashCode();
            numObj++;
        }
        public Cylinder(int Height, int Radius)
        {
            this.Height = Height;
            this.Radius = Radius;
            ID = Height.GetHashCode() + Radius.GetHashCode();
            numObj++;
        }
        static Cylinder()
        {
            numObj = 0;
            Console.WriteLine("STATIC CONSTRUCTOR: create first cylinder\n");
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Wrong parameter: Height. Repeat input:");
                    Height = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Wrong parameter: Radius. Repeat input:");
                    Radius = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public static void СalculateVolume(ref int Height, ref int Radius, out double Volume)
        {
            Volume = PI * (Radius * Radius) * Height;
        }
        public void Print()
        {
            Console.WriteLine("Height: {0}; Radius: {1}; ID: {2};", height.ToString(), radius.ToString(), ID.ToString());
        }
        public static int NumberObjects()
        {
            return numObj;
        }
        public static void ClassInfo()
        {
            Console.WriteLine("----This class realize Cylinder figure----");
        }
        public bool Equals(Cylinder Obj)
        {
            if (Obj == null)
                return false;

            return Obj.Height == this.Height && Obj.Radius == this.Radius;
        }
        public override int GetHashCode()
        {
            return Height.GetHashCode() + Radius.GetHashCode();
        }
    }  
}