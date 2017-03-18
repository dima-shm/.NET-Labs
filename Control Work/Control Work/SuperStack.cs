using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work
{
    //4.	Создать обобщённый класс SuperStack<T>, наследовать от стандартной коллекции Stack<T>.  
    //      Переопределить оператор == - для сравнения стеков по размеру, 
    //      если один из стеков нулевой длины выбрасывать исключение InsufficientExecutionStackException. 
    //      Написать демонстрацию для типа int с выводом и обработкой исключения.
    class SuperStack<T> : Stack<T>
    {
        T[] sstack;
        int count = 0;
        public int Count
        {
            get { return count; }
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public T this[int index]
        {
            get { return sstack.ElementAt<T>(index); }
        }
        public void Print()
        {
            for (int i = 0; i < count; i++ )
            {
                Console.Write(sstack[i] + " ");
            }
            Console.WriteLine();
        }

        public SuperStack()
        {
            sstack = new T[256];
        }    
        public T Pop()
        {
            return sstack[count];
        }
        public void Push( T item)
        {
            sstack[count++] = item;
        }
        
        public static bool operator ==(SuperStack<T> _sstack1, SuperStack<T> _sstack2)
        {
            if (_sstack1.Count == 0 || _sstack2.Count == 0)
                throw new InsufficientExecutionStackException();
            return _sstack1.Count == _sstack2.Count;
        }
        public static bool operator !=(SuperStack<T> _sstack1, SuperStack<T> _sstack2)
        {
            if (_sstack1.Count == 0 || _sstack2.Count == 0)
                throw new InsufficientExecutionStackException();
            return _sstack1.Count == _sstack2.Count;
        }
    }
}
