using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NeldnerMK.Sprint4.Task1.V11.Lib
{
    public class DataService : ISprint4Task1V11
    {
        //Дан одномерный целочисленный массив на 17 элементов заполненный
        //значениями с клавиатуры в диапазоне от 1 до 6 подсчитать сумму четных
        //элементов массива.  С клавиатуры: 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6
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
