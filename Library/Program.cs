using System;
using System.Runtime.Remoting.Channels;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shoppingCart = null;

            ConsoleColor ForegroundColor = Console.ForegroundColor;
            ConsoleColor BackgroundColor = Console.BackgroundColor;

            string[,] author = {
            { " М.Лермонтов " }, { "И.Тургенев" }, { "Л.Тостой" },
            { "\n| Ф.Достоевский" }, { " А.Пушкин " }, { "Н.Гоголь" },
            { "\n|  Стивен Кинг " }, { " Б.Стокер " }, { " К.Дойл " }};

            string[,] books = {
            // М.Лермонтов
            { "Герой нашего времени - (1, 1);", "Мцыри - (1, 2);", "Бородино - (1, 3);" },
            //И.Тургенев
            { "Отцы и дети - (2, 1);", "Муму - (2, 2);", "Записки охотника - (2, 3);" },
            //Ф.Достоевский
            { "Преступление и наказание - (3, 1);", "Братья Карамазовы - (3, 2);", "Бесы - (3, 3);" },
            //Л.Тостой
            { "Война и мир - (4, 1);", "После бала - (4, 2);", "Анна Каренина - (4, 3);" },
            //А.Пушкин
            { "Евгений Онегин - (5, 1);", "Медный всадник - (5, 2);", "Руслан и Людмила - (5, 3);" },
            //Н.Гоголь
            { "Ревизор - (6, 1);", "Мертвые души - (6, 2);", "Вий - (6, 3);" },
            //Б.Стокер
            { "Дракула - (7, 1);", "Сокровище Семи Звезд - (7, 2);", "Змеиный перевал - (7, 3);" },
            //Стивен Кинг
            { "Зелёная миля - (8, 1);", "Сияние - (8, 2);", "Кладбище домашних животных - (8, 3);" },
            //К.Дойл
            { "Собака Бискервилей - (9, 1);", "Приключения Шерлока Холмса - (9, 2);", "Затерянный мир - (9, 3);" }};

            bool isOpen = true;

            while (isOpen)
            {
                Random rand = new Random();

                Console.SetCursorPosition(0, 15);
                Console.WriteLine("'1' - Найти книгу по индексу\n'2' - Вывод всех авторов\n'3' - Найти книгу по автору" +
                                  "\n'4' - Рандомная книга\n'5' - Содержимое корзины\n'6' - выход");

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\tДобро пожаловать в библиотеку");
                Console.Write("\nВаш выбор: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("\nВведите номер полки: ");
                        int rows = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Ведите номер книги: ");
                        int cols = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine("\nВаша книга - " + books[rows, cols]);
                        Console.WriteLine("\nХотите добавить книгу в корзину - да|нет");

                        switch (Console.ReadLine().ToLower())
                        {
                            case "да":
                                shoppingCart = books[rows, cols];
                                Console.Write("\nКнига добавлена в корзину");
                                break;

                            case "нет":
                                Console.Write("\nНажмите для продолжения");
                                break;

                            default:
                                WriteError();
                                break;
                        }
                        Clean(); break;
                    
                    case "2":
                        Console.WriteLine("\nАвторы:");
                        Console.WriteLine();
                        Console.Write("| ");

                        foreach (string i in author)
                        {
                            Console.Write(i + " | ");
                        }
                        Clean(); break;

                    case "3":
                        Console.Write("Введите фамилию автора: ");
                        switch (Console.ReadLine().ToLower())
                        {
                            case "лермонтов":
                                Console.WriteLine("\nКниги Лермонтова:");
                                Console.Write($"\n{books[0, 0]}\n{books[0, 1]}\n{books[0, 2]}");
                                break;
                            case "тургенев":
                                Console.WriteLine("Книги Тургенева:");
                                Console.Write($"\n{books[1, 0]}\n{books[1, 1]}\n{books[1, 2]}");
                                break;
                            case "толстой":
                                Console.WriteLine("\nКниги Тостого:");
                                Console.Write($"\n{books[2, 0]}\n{books[2, 1]}\n{books[2, 2]}");
                                break;
                            case "достоевский":
                                Console.WriteLine("Книги Достоевского:");
                                Console.Write($"\n{books[3, 0]}\n{books[3, 1]}\n{books[3, 2]}");
                                break;
                            case "пушкин":
                                Console.WriteLine("\nКниги Пушкина:");
                                Console.Write($"\n{books[4, 0]}\n{books[4, 1]}\n{books[4, 2]}");
                                break;
                            case "гоголь":
                                Console.WriteLine("Книги Гоголя:");
                                Console.Write($"\n{books[5, 0]}\n{books[5, 1]}\n{books[5, 2]}");
                                break;
                            case "стокер":
                                Console.WriteLine("Книги Стокера:");
                                Console.Write($"\n{books[6, 0]}\n{books[6, 1]}\n{books[6, 2]}");
                                break;
                            case "кинг":
                                Console.WriteLine("\nКниги Кинга:");
                                Console.Write($"\n{books[7, 0]}\n{books[7, 1]}\n{books[7, 2]}");
                                break;
                            case "дойл":
                                Console.WriteLine("Книги Дойла:");
                                Console.Write($"\n{books[8, 0]}\n{books[8, 1]}\n{books[8, 2]}");
                                break;
                            default:
                                WriteError();
                                break;
                        }
                        Clean(); break;

                    case "4":
                        int r = rand.Next(0, 8), c = rand.Next(0, 2);
                        Console.Write("Рандом выбрал - " + books[r, c]);

                        switch (Console.ReadLine().ToLower())
                        {
                            case "да":
                                shoppingCart = books[r, c];
                                Console.Write("\nКнига добавлена в корзину");
                                break;

                            case "нет":
                                Console.Write("\nНажмите для продолжения");
                                break;

                            default:
                                WriteError();
                                break;
                        }
                        Clean(); break;

                    case "5":
                        Console.Write("Корзина: ");
                        Console.Write(shoppingCart);

                        if (shoppingCart == null) Console.Write("В вашей корзине пусто :(");

                        Clean(); break;

                    case "6":
                        Console.Clear();
                        isOpen = false;
                        break;

                    case "custom":
                        Console.WriteLine("'1' - Цвет консоли, '2' - Цвет текста, '3' - Удалить изменения");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Цвета: '1' - Зеленый, '2' - Синий, '3' - Желтый, '4' - Красный, '5' - Фиолетовый");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                        break;
                                    case "2":
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        break;
                                    case "3":
                                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                                        break;
                                    case "4":
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        break;
                                    case "5":
                                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                        break;
                                    default:
                                        WriteError();
                                        break;
                                }
                                break;

                            case "2":
                                Console.WriteLine("Цвета: '1' - Зеленый, '2' - Синий, '3' - Желтый, '4' - Красный, '5' - Фиолетовый");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        break;
                                    case "2":
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        break;
                                    case "3":
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        break;
                                    case "4":
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        break;
                                    case "5":
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        break;
                                    default: WriteError();
                                        break;
                                }
                                break;

                            case "3":
                                Console.ForegroundColor = ForegroundColor;
                                Console.ForegroundColor = BackgroundColor;
                                break;

                            default:
                                WriteError();
                                break;
                        }
                        Console.Clear(); break;

                    default: WriteError();
                        break;
                }
            }
        }
        static void WriteError()
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неизвестная команда");
            Console.ForegroundColor = color;
            Clean();
        }
        static void Clean()
        {
            Console.ReadKey(); Console.Clear();
        }
    }
}
