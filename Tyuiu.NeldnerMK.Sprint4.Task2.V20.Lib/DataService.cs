using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NeldnerMK.Sprint4.Task2.V20.Lib
{
    public class DataService : ISprint4Task2V20
    {
   

        //Дан одномерный целочисленный массив на 16 элементов заполненный
        //случайными в диапазоне от 2 до 7 подсчитать сумму четных элементов массива.
        public int Calculate(int[] array)
        {
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