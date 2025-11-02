using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint4.Task0.V9.Lib;


namespace Tyuiu.NeldnerMK.Sprint4.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #4                                                               *");
            Console.WriteLine("* Задание #0                                                          *");
            Console.WriteLine("* Вариант #9                                                          *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7} ");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            DataService ds = new DataService();

            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };



            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(ds.GetSumEvenArrEl(array));
            
        }
    }
}
