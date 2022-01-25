using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: "); //Выводим консоль с сообщением
            var name = Console.ReadLine(); //Записываем имя пользователя из консоли в переменную
            Console.WriteLine($"Привет, {name}, сегодня, {DateTime.Now.ToString()}!"); //Выводим текст в консоль.
            Console.ReadKey();
     
        }
    }
}
