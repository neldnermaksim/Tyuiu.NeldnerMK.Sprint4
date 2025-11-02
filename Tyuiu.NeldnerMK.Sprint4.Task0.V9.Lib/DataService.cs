using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NeldnerMK.Sprint4.Task0.V9.Lib
{
    public class DataService : ISprint4Task0V9
    {
        public int GetSumEvenArrEl(int[] array)
        {
            // Дан одномерный целочисленный массив на 10 элементов заполненный
            // статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных
            // элементов массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}