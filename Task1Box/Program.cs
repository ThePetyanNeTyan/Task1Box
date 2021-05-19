using System;
using System.Linq;

namespace Task1Box
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Игорь";
            int age = 16;
            int height = 170;

            int history=5;
            int math=3;
            int russianLanguage=4;
            int score = LessonValue(history, math, russianLanguage);

            ConsoleOutputOriginal(name, age, height, history, math, russianLanguage, score); /// вывод в консоль данных как есть
            ConsoleOutputFormat(name, age, height, history, math, russianLanguage, score); /// вывод форматированных данных в консоль
            ConsoleOutputInterPol(name, age, height, history, math, russianLanguage, score); /// вывод данных используя интерполяцию
            ConsoleOutputCenter(name, age, height, history, math, russianLanguage, score); ///вывод данных по центру консоли
        }

        public static int LessonValue(params int[] values) ///метод высчитывания среднего балла с помощью парамс(классная штука)
        {
            return values.Sum(x => x) / values.Length;
        }

        public static void ConsoleOutputFormat(string name, int age, int height,int history, 
            int math, int russianLanguage, int score) /// метод вывода в консоль форматированных данных
        {
            string pattern = "Имя: {0}  \nВозраст: {1} \nРост: {2} \nБалл по истории: {3}" +
                             " \nБалл по математике: {4} \nБалл по русскому языку: {5} \nСредний балл по 3ем предметам: {6} ";

            Console.WriteLine(pattern,
                name,
                age,
                height,
                history,
                math,
                russianLanguage,
                score);
        }

        public static void ConsoleOutputInterPol(string name, int age, int height, int history,
            int math, int russianLanguage, int score) /// вывод в консоль данных с интерполяцией
        {
            Console.WriteLine($"Имя: {name}  \nВозраст: {age} \nРост: {height} \nБалл по истории: {history}" +
                             $" \nБалл по математике: {math} \nБалл по русскому языку: {russianLanguage} \nСредний балл по 3ем предметам: {score} ");
        }

        public static string ConsoleOutputOriginal(string name, int age, int height, int history,
            int math, int russianLanguage, int score) /// вывод в консоль оригинал
        {
            var str = name + ' ' + age + ' ' + height + ' ' + history + ' ' + math + ' ' + russianLanguage + ' ' + score;
            Console.WriteLine(str);
            return str;
        }

        public static void ConsoleOutputCenter(string name, int age, int height, int history,
            int math, int russianLanguage, int score) /// вывод по центру консоли
        {
            string pattern = ConsoleOutputOriginal(name, age, height, history,math,russianLanguage,score);
            int centerX = (Console.WindowWidth / 2) - (pattern.Length / 2); /// находим точку по х
            int centerY = (Console.WindowHeight / 2) - 1; /// находим точку по y
            Console.SetCursorPosition(centerX, centerY); /// ставим курсос в центр по найденным точкам
            Console.Write(pattern);
        }
    }
}
