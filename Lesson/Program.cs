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
            Console.Write("Введите имя пользователя: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня, {DateTime.Now.ToString()}!");
            Console.ReadKey();
     
        }
    }
}
