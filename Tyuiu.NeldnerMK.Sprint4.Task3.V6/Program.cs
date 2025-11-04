using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint4.Task3.V6.Lib;


namespace Tyuiu.NeldnerMK.Sprint4.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #4                                                               *");
            Console.WriteLine("* Задание #3                                                          *");
            Console.WriteLine("* Вариант #6                                                          *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу ");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            DataService ds = new DataService();

            int[,] array = { { 8, 8, 3, 4, 5 }, { 8, 6, 6, 4, 6 }, { 3, 6, 5, 3, 4 }, { 5, 6, 3, 7, 5 }, { 7, 8, 5, 6, 6 } };

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate(array));
        }
    }
}
