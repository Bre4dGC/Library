using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string shoppingCart = null;

            string[,] author = { 
            { " М.Лермонтов " }, { "И.Тургенев" }, { "Л.Тостой" },
            { "\n| Ф.Достоевский" }, { " А.Пушкин " }, { "Н.Гоголь" },
            { "\n|  Стивен Кинг " }, { " Б.Стокер " }, { " К.Дойл " }};
            
            string[,] books = {
            // М.Лермонтов
            { "Герой нашего времени", "Мцыри", "Бородино" },
            //И.Тургенев
            { "Отцы и дети", "Муму", "Записки охотника " },
            //Ф.Достоевский
            { "Преступление и наказание", "Братья Карамазовы", "Бесы" },
            //Л.Тостой
            { "Война и мир", "После бала", "Анна Каренина" },
            //А.Пушкин
            { "Евгений Онегин", "Медный всадник", "Руслан и Людмила" },
            //Н.Гоголь
            { "Ревизор", "Мертвые души", "Вий" },
            //Б.Стокер
            { "Дракула", "Сокровище Семи Звезд", "Змеиный перевал" },
            //Стивен Кинг
            { "Зелёная миля", "Сияние", "Кладбище домашних животных" },
            //К.Дойл
            { "Собака Бискервилей", "Приключения Шерлока Холмса", "Затерянный мир" }};

            while (isOpen)
            {   
                Random rand = new Random();

                Console.SetCursorPosition(0, 15);
                Console.WriteLine("'1' - Вывод всех авторов\n'2' - Найти книгу по автору \n'3' - Найти книгу по индексу\n'4' - Рандомная книга\n'5' - Содержимое корзины\n'6' - выход");
                
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\tДобро пожаловать в библиотеку");
                Console.Write("\nВаш выбор: ");
                
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("\nАвторы:");
                        Console.WriteLine();
                        Console.Write("| ");

                        for (int i = 0; i < author.GetLength(0); i++)
                        {
                            for (int j = 0; j < author.GetLength(1); j++)
                            {
                                Console.Write(author[i, j] + " | ");
                            }
                        }
                        
                        Console.ReadKey(); Console.Clear();
                        break;

                    case 2:
                        Console.Write("Введите фамилию автора: ");
                        switch (Console.ReadLine())
                        {
                            case "Лермонтов":
                                Console.WriteLine("\nКниги Лермонтова:");
                                Console.Write($"\n{books[0, 0]} - (1, 1);\n{books[0, 1]} - (1, 2);\n{books[0, 2]} - (1, 3);");
                                break;
                            case "Тургенев":
                                Console.WriteLine("Книги Тургенева:");
                                Console.Write($"\n{books[1, 0]} - (2, 1);\n{books[1, 1]} - (2, 2);\n{books[1, 2]} - (2, 3);");
                                break;
                            case "Тостой":
                                Console.WriteLine("\nКниги Тостого:");
                                Console.Write($"\n{books[2, 0]} - (3, 1);\n{books[2, 1]} - (3, 2);\n{books[2, 2]} - (3, 3);");
                                break;
                            case "Достоевский":
                                Console.WriteLine("Книги Достоевского:");
                                Console.Write($"\n{books[3, 0]} - (4, 1);\n{books[3, 1]} - (4, 2);\n{books[3, 2]} - (4, 3);");
                                break;
                            case "Пушкин":
                                Console.WriteLine("\nКниги Пушкина:");
                                Console.Write($"\n{books[4, 0]} - (5, 1);\n{books[4, 1]} - (5, 2);\n{books[4, 2]} - (5, 3);");
                                break;
                            case "Гоголь":
                                Console.WriteLine("Книги Гоголя:");
                                Console.Write($"\n{books[5, 0]} - (6, 1);\n{books[5, 1]} - (6, 2);\n{books[5, 2]} - (6, 3);");
                                break;
                            case "Стокер":
                                Console.WriteLine("Книги Стокера:");
                                Console.Write($"\n{books[6, 0]} - (7, 1);\n{books[6, 1]} - (7, 2);\n{books[6, 2]} - (7, 3);");
                                break;
                            case "Кинг":
                                Console.WriteLine("\nКниги Кинга:");
                                Console.Write($"\n{books[7, 0]} - (8, 1);\n{books[7, 1]} - (8, 2);\n{books[7, 2]} - (8, 3);");
                                break;
                            case "Дойл":
                                Console.WriteLine("Книги Дойла:");
                                Console.Write($"\n{books[8, 0]} - (9, 1);\n{books[8, 1]} - (9, 2);\n{books[8, 2]} - (9, 3);");
                                break;
                            default:
                                Console.WriteLine("Неизвестный автор");
                                break;
                        }
                        Console.ReadKey(); Console.Clear(); break;

                    case 3:
                        Console.Write("\nВведите номер полки: ");
                        int rows = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Ведите номер книги: ");
                        int cols = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("\nВаша книга - " + books[rows, cols]);
                        Console.WriteLine("\nХотите добавить книгу в корзину - да|нет");
                        switch (Console.ReadLine())
                        {
                            case "да":
                                shoppingCart = books[rows, cols];
                                Console.Write("\nКнига добавлена в корзину");
                                break;

                            case "нет":
                                Console.Write("\nНажмите для продолжения");
                                break;

                            default: Console.Write("Неизвестная команда");
                                break;
                        }
                        Console.ReadKey(); Console.Clear();
                        break;

                    case 4:
                        int r = rand.Next(0, 8), c = rand.Next(0, 2);
                        Console.Write("Рандом выбрал - " + books[r, c]); Console.ReadKey(); Console.Clear(); break;

                    case 5:
                        Console.WriteLine("Содержимое вашей корзины:");
                        Console.WriteLine(shoppingCart);

                        if (shoppingCart == null) Console.Write("В вашей корзине пусто :(");
                        
                        Console.ReadKey(); Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
        }
    }
}
