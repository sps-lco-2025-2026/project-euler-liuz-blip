
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        // Problem 1

        void Problem1()
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        // Problem1();



        // Problem 2

        void Problem2()
        {
            int sum = 0;

            int num1 = 1;
            int num2 = 2;
            int numTemp = 0;

            while (num2 < 4000000)
            {
                if (num2 % 2 == 0)
                {
                    sum += num2;
                }
                numTemp = num2;
                num2 += num1;
                num1 = numTemp;
            }
            Console.WriteLine(sum);
        }
        // Problem2();



        // Problem 3

        void Problem3(long num)
        {
            bool IsPrime(long n)
            {
                if (n < 0) { n = -n; }
                if (n == 0 || n == 1) return false;

                for (int i = 2; i < (n / 2) + 1; i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
            // Console.WriteLine(IsPrime(3));

            if (IsPrime(num)) Console.WriteLine(num);
            for (long i = 2; i < num; i++)
            {
                if (num % i != 0) continue;
                long factor = num / i;
                if (IsPrime(factor)) { Console.WriteLine(factor); break; }
            }
        }
        // Problem3(600851475143);



        // Problem 4

        void Problem4()
        {
            bool isPalindrome(int n)
            {
                string nStr = n.ToString();
                for (int i = 0; i < nStr.Length / 2; i++)
                {
                    if (nStr[i] != nStr[nStr.Length - 1 - i]) return false;
                }
                return true;
            }

            int maxPalindrome = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    if (isPalindrome(product) && product > maxPalindrome)
                    {
                        maxPalindrome = product;
                    }
                }
            }
            Console.WriteLine(maxPalindrome);
        }
        // Problem4();



        // Problem 5

        void Problem5()
        {
            bool even_div(int num)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (num % i != 0) return false;
                }
                return true;
            }

            int current = 2025;
            while (true)
            {
                if (even_div(current)) { break; }
                current++;
            }
            Console.WriteLine(current);
        }
        // Problem5();



        // Problem 6

        void Problem6()
        {
            int sum_of_squares()
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i * i;
                }
                return sum;
            }

            int square_of_sums()
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                return sum * sum;
            }

            Console.WriteLine(square_of_sums() - sum_of_squares());
        }
        // Problem6();



        // Problem 7

        void Problem7()
        {
            bool is_prime(int n)
            {
                for (int i = 2; i < n/2 + 1; i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

            int counter = 0;
            int current = 1;
            while (counter <= 10001)
            {
                current++;
                if (is_prime(current)) { counter++; }
            }
            Console.WriteLine(current);
        }
        Problem7();



        // Problem 11

        void Problem11()
        {
            List<List<int>> grid = [
                [08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08],
                [49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00],
                [81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65],
                [52 ,70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91],
                [22 ,31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80],
                [24 ,47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50],
                [32 ,98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70],
                [67 ,26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21],
                [24 ,55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72],
                [21 ,36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95],
                [78 ,17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92],
                [16 ,39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57],
                [86 ,56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58],
                [19 ,80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40],
                [04 ,52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66],
                [88 ,36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69],
                [04 ,42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36],
                [20 ,69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16],
                [20 ,73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54],
                [01 ,70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48]];

            int max_product = 0;
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    int u = 0;
                    if (y >= 3) { u = grid[y][x] * grid[y - 1][x] * grid[y - 2][x] * grid[y - 3][x]; }
                    if (u > max_product) max_product = u;

                    int ur = 0;
                    if (y >= 3 && grid.Count() - 3 - 1 >= x) { ur = grid[y][x] * grid[y - 1][x + 1] * grid[y - 2][x + 2] * grid[y - 3][x + 3]; }
                    if (ur > max_product) max_product = ur;

                    int r = 0;
                    if (grid.Count() - 3 - 1 >= x) { r = grid[y][x] * grid[y][x + 1] * grid[y][x + 2] * grid[y][x + 3]; }
                    if (r > max_product) max_product = r;

                    int dr = 0;
                    if (grid.Count() - 3 - 1 >= y && grid.Count() - 3 - 1 >= x) { dr = grid[y][x] * grid[y + 1][x + 1] * grid[y + 2][x + 2] * grid[y + 3][x + 3]; }
                    if (dr > max_product) max_product = dr;

                    int d = 0;
                    if (grid.Count() - 3 - 1 >= y) { d = grid[y][x] * grid[y + 1][x] * grid[y + 2][x] * grid[y + 3][x]; }
                    if (d > max_product) max_product = d;

                    int dl = 0;
                    if (grid.Count() - 3 - 1 >= y && x >= 3) { dl = grid[y][x] * grid[y + 1][x - 1] * grid[y + 2][x - 2] * grid[y + 3][x - 3]; }
                    if (dl > max_product) max_product = dl;

                    int l = 0;
                    if (x >= 3) { l = grid[y][x] * grid[y][x - 1] * grid[y][x - 2] * grid[y][x - 3]; }
                    if (l > max_product) max_product = l;

                    int ul = 0;
                    if (y >= 3 && x >= 3) { ul = grid[y][x] * grid[y - 1][x - 1] * grid[y - 2][x - 2] * grid[y - 3][x - 3]; }
                    if (ul > max_product) max_product = ul;
                }
            }
            Console.WriteLine(max_product);
        }
        // Problem11();

    }
}