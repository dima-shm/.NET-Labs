using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--- Вариант 4 ---*/


            //1.  А) Вывести максимально допустимое число типа ushort
            //    Б) Проверить содержит ли произвольная строка число 123.
            //    С) Создать двумерный массив double , заполнить случайными числами
            Console.WriteLine("1.");
            /*- A -*/
            Console.WriteLine("А) Максимально допустимое число типа ushort = {0}", ushort.MaxValue);
            /*- Б -*/
            string str = "4561235",
                   podstr = "123";
            if (str.Contains(podstr))
                Console.WriteLine("Б) Строка {0} содержит значение \"{1}\"", str, podstr);
            else
                Console.WriteLine("Б) Строка {0} не содержит значение \"{1}\"", str, podstr);
            /*- С -*/
            int[,] mass = new int[5, 5];
            Random rand = new Random();
            Console.WriteLine("С) Двумерный массив со случаными значениями типа int");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < 5; j++)
                {
                    mass[i, j] = rand.Next();
                    Console.Write("(" + mass[i, j] + ") ");
                }
                Console.WriteLine();
            }


            //2.	Создать класс Date с day; month; year. 
            //      Для дня и месяца сделать автоматические свойства, а для года  свойство только для чтения. 
            //      Переопределить метод Equals и сравнить  две даты.
            Console.WriteLine("\n2.");
            Date date1 = new Date();
            date1.Day = 18;
            date1.Month = 3;

            Date date2 = new Date(19, 3);

            if (date1.Equals(date2))
                Console.WriteLine("Дата {0} равна дате {1}", date1.ToString(), date2.ToString());
            else
                Console.WriteLine("Дата {0}  не равна дате {1}", date1.ToString(), date2.ToString());


            //3.	Создать интерфейс IGood с методом plus(). 
            //      Создать интерфейс IBad с методом minus(). 
            //      Создать абстрактный класс People (пустой). 
            //      Классы Student и Prepod наследуются от People. 
            //      Реализовать все интерфейсы в классе Student и интерфейс IGood в классе Prepod (по-разному). 
            Console.WriteLine("\n3.");
            Student student = new Student();
            student.plus();
            student.minus();
            Prepod prepod = new Prepod();
            prepod.plus();


            //4.	Создать обобщённый класс SuperStack<T>, наследовать от стандартной коллекции Stack<T>.  
            //      Переопределить оператор == - для сравнения стеков по размеру, 
            //      если один из стеков нулевой длины выбрасывать исключение InsufficientExecutionStackException. 
            //      Написать демонстрацию для типа int с выводом и обработкой исключения.
            Console.WriteLine("\n4.");
            SuperStack<int> sstack1 = new SuperStack<int>();
            sstack1.Push(1);
            sstack1.Push(2);
            sstack1.Push(3);
            Console.Write("Содержимое стека sstack1: ");
            sstack1.Print();
            SuperStack<int> sstack2 = new SuperStack<int>();
            sstack2.Push(4);
            sstack2.Push(5);
            sstack2.Push(6);
            Console.Write("Содержимое стека sstack2: ");
            sstack2.Print();
            if (sstack1 == sstack2)
                Console.WriteLine("Размер sstack1 равен sstack2");
            else
                Console.WriteLine("Размер sstack1 не равен sstack2");


            //5     Создать массив строк разной длины. 
            //      На основе LINQ подсчитать количество строк c длинной большей 5.
            Console.WriteLine("\n5.");
            string str1 = "123",
                   str2 = "1234",
                   str3 = "12345",
                   str4 = "123456",
                   str5 = "1234567";
            string[] massStr = new string[5] {str1 ,str2, str3, str4, str5};
            var StringLength = from string item in massStr
                                     where item.Length > 5
                                     select item;
            Console.WriteLine("Количество строк длиной больше 5: " + StringLength.Count());
            Console.Write("Строки длиной больше 5: ");
            foreach (string item in StringLength)
                Console.Write("\"" + item + "\", ");
            Console.WriteLine();
        }
    }
}
