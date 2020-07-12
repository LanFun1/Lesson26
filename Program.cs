using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите символ, из которого хотите сделать прямоугольник");
            char symbol = Convert.ToChar(Console.ReadLine());
            string rectangleSide = "";
            for (int i =0; i< name.Length+2; i++)
                 rectangleSide += symbol;
            Console.WriteLine($"{rectangleSide}\n{symbol}{name}{symbol}\n{rectangleSide}");
        }
    }
}
