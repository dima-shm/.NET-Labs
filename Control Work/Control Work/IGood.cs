using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work
{
    //3.	Создать интерфейс IGood с методом plus(). 
    //      Создать интерфейс IBad с методом minus(). 
    //      Создать абстрактный класс People (пустой). 
    //      Классы Student и Prepod наследуются от People. 
    //      Реализовать все интерфейсы в классе Student и интерфейс IGood в классе Prepod (по-разному). 
    interface IGood
    {
        void plus();
    }
    interface IBad
    {
        void minus();
    }
    abstract class People { }
    class Student : People, IGood, IBad
    {
        public void plus()
        {
            Console.WriteLine("Класс Student, метода plus");
        }
        public void minus()
        {
            Console.WriteLine("Класс Student, метода minus");
        }
    }
    class Prepod : People, IGood
    {
        public void plus()
        {
            Console.WriteLine("Класс Prepod, метода plus");
        }
    }
}
