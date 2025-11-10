using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint4.Task5.V13.Lib;


namespace Tyuiu.NeldnerMK.Sprint4.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #4                                                               *");
            Console.WriteLine("* Задание #5                                                          *");
            Console.WriteLine("* Вариант #13                                                         *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу ");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            Random rdm = new Random();
            DataService ds = new DataService();

            Console.Write("Введите количество строк массива: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    
                    matrix[i, j] = rdm.Next(-2,6);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int[,] res = ds.Calculate(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{res[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

