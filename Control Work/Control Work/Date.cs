using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work
{
    //2.	Создать класс Date с day; month; year. 
    //      Для дня и месяца сделать автоматические свойства, а для года  свойство только для чтения. 
    //      Переопределить метод Equals и сравнить  две даты.
    class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public readonly int Year;

        public Date()
        {
            Year = 2017;
        }
        public Date(int _day, int _mounth)
        {
            Day = _day;
            Month = _mounth;
            Year = 2017;
        }
        public new bool Equals(Date obj)
        {
            if (obj == null)
                return false;

            return obj.Day == this.Day && obj.Month == this.Month && obj.Year == this.Year;
        }
        public new string ToString()
        {
            return Day + "." + Month + "." + Year;
        }
    }
}
