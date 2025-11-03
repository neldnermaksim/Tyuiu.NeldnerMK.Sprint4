using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint4.Task2.V20.Lib;


namespace Tyuiu.NeldnerMK.Sprint4.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #4                                                               *");
            Console.WriteLine("* Задание #2                                                          *");
            Console.WriteLine("* Вариант #20                                                          *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу ");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            Random rdm = new Random();
            DataService ds = new DataService();

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i < len; i++)
            {
                ;
                numsArry[i] = rdm.Next(2,7);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i < numsArry.Length; i++)
            {
                Console.WriteLine(numsArry[i]);
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(ds.Calculate(numsArry));

        }
    }
}
