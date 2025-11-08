using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NeldnerMK.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        //Дан строковый массив данных ["Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей"]
        //используя класс Array подсчитайте количество элементов, длина которых больше 6.
        public int Calculate(string[] array)
        {
            int count = array.Count(array => array.Length > 6);

            return count;
        }
    }
}
