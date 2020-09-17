using System;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            Console.WriteLine("Введите имя первого игрока: ");
            string user1Name = Console.ReadLine();
            Console.WriteLine("Введите имя второго игрока: ");
            string user2Name = Console.ReadLine();
            Console.WriteLine("Сколько чисел можно вычитать за 1 раз: ");
            int userTry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стартовое число для генерации:");
            int gameNumberLow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное число для генерации:");
            int gameNumberHigh = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int gameNumber = rnd.Next(gameNumberLow, gameNumberHigh);

            int user1Try = 0;
            int user2Try = 0;

            Console.WriteLine($"Компуктер выбрал число {gameNumber}!");

            int i = 0;
            while (true)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Число: {gameNumber}");
                    Console.WriteLine($"Ход игрока {user1Name}:");
                    user1Try = Convert.ToInt32(Console.ReadLine());
                    if (user1Try <= userTry && user1Try > 0)
                    {
                        gameNumber -= user1Try;
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"Победил {user1Name}");
                            Console.ReadKey();
                            break;
                        }
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Не жульничать!");
                        continue;
                    }


                }
                else
                {
                    Console.WriteLine($"Число: {gameNumber}");
                    Console.WriteLine($"Ход компьютера с именем {user2Name}");
                    user2Try = rnd.Next(1, userTry + 1);
                    Console.WriteLine($"Компьютер выбрал число {user2Try}");
                    gameNumber -= user2Try;
                    if (gameNumber == 0)
                    {
                        Console.WriteLine($"Победил {user2Name}");
                        Console.ReadKey();
                        break;
                    }
                    i--;
                }

            }

            //int i = 0;
            //while (true)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine($"Число: {gameNumber}");
            //        Console.WriteLine($"Ход игрока {user1Name}:");
            //        user1Try = Convert.ToInt32(Console.ReadLine());
            //        if (user1Try <= userTry && user1Try > 0)
            //        {
            //            gameNumber -= user1Try;
            //            if (gameNumber == 0)
            //            {
            //                Console.WriteLine($"Победил {user1Name}");
            //                Console.ReadKey();
            //                break;
            //            }
            //            i++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Не жульничать!");
            //            continue;
            //        }


            //    }
            //    else
            //    {
            //        Console.WriteLine($"Число: {gameNumber}");
            //        Console.WriteLine($"Ход игрока {user2Name}:");
            //        user2Try = Convert.ToInt32(Console.ReadLine());
            //        if (user2Try <= userTry && user2Try > 0)
            //        {
            //            gameNumber -= user2Try;
            //            if (gameNumber == 0)
            //            {
            //                Console.WriteLine($"Победил {user2Name}");
            //                Console.ReadKey();
            //                break;
            //            }
            //            i--;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Не жульничать!");
            //            continue;
            //        }
            //    }

            //}


        }
    }
}
