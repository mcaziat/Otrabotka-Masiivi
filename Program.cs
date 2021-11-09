using System;

namespace Otrabotka
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VARIANT Массив
            //Console.WriteLine("Введите колличество массивов N - ");
            //int n = int.Parse(Console.ReadLine()); // будет количество массивов

            //Random rnd = new Random();

            //int[] a = new int[n]; //инициализация массивов

            //for (int i = 0; i < a.Length; i++) // цикл на перебор массива
            //{
            //    a[i] = rnd.Next(-100, 101);
            //    Console.WriteLine($"{a[i]}, ");
            //}
            //Console.ReadKey();

            #endregion

            #region VARIANT 2 поиск четных и нечетных массивов
            //Console.WriteLine("Кароче, теперь давай определим количество нечетных массивов в N колличестве чисел");

            //Console.WriteLine("Enter number N:");
            //int n = int.Parse(Console.ReadLine()); // назначили количество массивов

            //Random rnd = new Random(); // создали рандом

            //var mas = new int[n]; // назначили количество массивов в переменную

            //int unevenMas = 0; // перпеменная для нечетных массивов
            //int evenMas = 0; // переменная для четных массивов

            //for (int i = 0; i < mas.Length; i++) // цикл на прогон массивов по очереди
            //{
            //    mas[i] = rnd.Next(20); // присвоили в цикле значение каждому массиву
            //    Console.Write($"{mas[i]} ");
            //    if (mas[i] % 2 != 0) unevenMas++; // деление + счетчик на нечетное
            //    else
            //    {
            //        evenMas++; //счетчик четных
            //    }

            //}

            //Console.WriteLine($"\nНечетных элементов найдено: {unevenMas} \nЧетных элементов найдено: {evenMas}");
            //Console.ReadKey();
            #endregion

            #region VARIANT 3 поиск числа среди массивов
            //Random random = new Random(); // создали рандом
            //int[] numbs = new int [10]; //определили размер массива

            //for (int i = 0; i < numbs.Length; i++) //цикл на перебор массива с присвоением ему значения и вывода всех значений на экран
            //{
            //    numbs[i] = random.Next(1, 21);
            //    Console.Write($"{numbs[i]} ");
            //}

            //Console.Write("Введите число для поиска: ");
            //int n = int.Parse(Console.ReadLine());

            //int find = 0; //переменная для колличества найденыых совпадений

            //for (int i = 0; i < numbs.Length; i++) //цикл на прогон присвоенных значений массива + счетчик
            //{
            //    if (numbs[i] == n) find++;
            //}

            //Console.WriteLine($"\nКолличество найденых совпадений - {find}");
            //Console.ReadKey();
            #endregion

            #region VARIANT 4 сортировка массива без пузырька

            Console.WriteLine("Введите количество элементов: "); // пользователь вводит количество элементов 
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] numbs = new int[n];

            Console.Write("\nИсходный Массив ");

            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = random.Next(0, 2);
                Console.Write($"{numbs[i]} ");
            }

            int head = 0;
            int tail = numbs.Length - 1;

            bool flag = true;

            while (head < tail) // цикл пока хед меньше хвост цикл работает
            {
                if(flag) // пока флаг ТРУ - иф работает
                {
                    if (numbs[head] == 1) flag = false; // как только значение head станет равно единице, то запускается элс 
                    else head++;
                }
                else // как только флаг станет ФОЛС работает это условие.
                {
                    if (numbs[tail] == 0) flag = true;
                    else tail--;
                }

                if(numbs[head]==1 && numbs[tail]==0)
                {
                    int temp = numbs[head];

                    numbs[head] = numbs[tail];
                    numbs[tail] = temp;

                    head++;
                    tail--;
                }
            }

            Console.Write("\nПолучившейся массив: ");

            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write($"{numbs[i]} ") ;
            }

            Console.ReadKey();





            #endregion
        }
    }
}
