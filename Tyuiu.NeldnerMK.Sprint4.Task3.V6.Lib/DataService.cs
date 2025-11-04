using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NeldnerMK.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный
        //статическими значениями в диапазоне от 3 до 8. Найдите максимальный элемент
        //во второй строке массива.


        public int Calculate(int[,] array)
        {
            int max = array[1, 0];

            for (int i = 0; i < array.GetLength(1) ; i++)
            {
                if (array[1, i] > max)
                {
                    max = array[1, i];
                }
            }
            return max;
                
        }
    }
}