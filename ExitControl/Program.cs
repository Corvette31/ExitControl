using System;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            while (userInput != "exit")
            {
                Console.Write("Я буду выводить это сообщения, пока вы не напишите слово exit.\nВведите слово : ");
                userInput = Console.ReadLine();
            }
            Console.Write("Выхожу...");
        }
    }
}
