using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.NeldnerMK.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            //Дана строка из одноразрядных цифр "753159864". Преобразуйте ее в матрицу 3 на 3 и подсчитайте
            //количество четных чисел
            int[,] mtrx = new int[n,m];

            int count = 0;  

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));

                    if (mtrx[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
