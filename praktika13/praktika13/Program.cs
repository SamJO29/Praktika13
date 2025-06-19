namespace praktika13
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВыберите задание (1-24) или 0 для выхода:");
                string input = Console.ReadLine();

                
                if (input == "0")
                {
                    Console.WriteLine("Выход из программы...");
                    break;
                }

                if (!int.TryParse(input, out int task) || task < 1 || task > 24)
                {
                    Console.WriteLine("Неверный номер задания. Попробуйте снова.");
                    continue;
                }

                // Вызовы  задания
                switch (task)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
                        break;
                    case 10:
                        Task10();
                        break;
                    case 11:
                        Task11();
                        break;
                    case 12:
                        Task12();
                        break;
                    case 13:
                        Task13();
                        break;
                    case 14:
                        Task14();
                        break;
                    case 15:
                        Task15();
                        break;
                    case 16:
                        Task16();
                        break;
                    case 17:
                        Task17();
                        break;
                    case 18:
                        Task18();
                        break;
                    case 19:
                        Task19();
                        break;
                    case 20:
                        Task20();
                        break;
                    case 21:
                        Task21();
                        break;
                    case 22:
                        Task22();
                        break;
                    case 23:
                        Task23();
                        break;
                    case 24:
                        Task24();
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear(); 
            }
        }

        // 1. Удалить текст в скобках
        static void Task1()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            string result = "";
            bool inBrackets = false;

            foreach (char c in text)
            {
                if (c == '(')
                    inBrackets = true;
                else if (c == ')')
                    inBrackets = false;
                else if (!inBrackets)
                    result += c;
            }

            Console.WriteLine("Результат: " + result);
        }

        // 2. Сколько раз встречается заданное слово
        static void Task2()
        {
           Console.WriteLine("Введите текст:");
    string text = Console.ReadLine();
    Console.WriteLine("Введите слово для поиска:");
    string word = Console.ReadLine().ToLower(); // Приводим к нижнему регистру для сравнения

    int count = 0;
    int wordLength = word.Length;
    
    for (int i = 0; i <= text.Length - wordLength; i++)
    {
        // Проверяем, совпадает ли текущая подстрока с искомым словом
        bool match = true;
        for (int j = 0; j < wordLength; j++)
        {
            if (char.ToLower(text[i + j]) != word[j])
            {
                match = false;
                break;
            }
        }

        if (match)
        {
            // Проверяем границы слова
            bool leftBoundary = (i == 0) || !char.IsLetterOrDigit(text[i - 1]);
            bool rightBoundary = (i + wordLength == text.Length) || !char.IsLetterOrDigit(text[i + wordLength]);
            
            if (leftBoundary && rightBoundary)
            {
                count++;
                i += wordLength - 1; // Пропускаем проверенные символы
            }
        }
    }

    Console.WriteLine($"Слово '{word}' встречается {count} раз(а)");
        }

        // 3. Заменить пробелы на запятую и пробел
        static void Task3()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            string result = text.Replace(" ", ", ");
            Console.WriteLine("Результат: " + result);
        }

        // 4. Процент слов на букву К
        static void Task4()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            int count = 0;

            foreach (string word in words)
            {
                if (word.Length > 0 && word[0] == 'К')
                    count++;
                
            }

            double percent = (double)count / words.Length * 100;
            Console.WriteLine($"Процент слов на 'К': {percent:F2}%");
        }

        // 5. Удалить все цифры из строки
        static void Task5()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string result = "";

            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    result += c;
            }

            Console.WriteLine("Результат: " + result);
        }

        // 6. Проверить, есть ли символы кроме букв и пробелов
        static void Task6()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            bool hasOther = false;

            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    hasOther = true;
                    break;
                }
            }

            Console.WriteLine(hasOther ? "Есть другие символы" : "Только буквы и пробелы");
        }

        // 7. Удалить буквы с ASCII-кодами 70-75
        static void Task7()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string result = "";

            foreach (char c in text)
            {
                if (c < 70 || c > 75)
                    result += c;
            }

            Console.WriteLine("Результат: " + result);
        }

        // 8. Проверить, есть ли две "4" подряд
        static void Task8()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            bool hasTwoFours = false;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == '4' && text[i + 1] == '4')
                {
                    hasTwoFours = true;
                    break;
                }
            }

            Console.WriteLine(hasTwoFours ? "Есть две 4 подряд" : "Нет двух 4 подряд");
        }

        // 9. Вставить пробел после каждой цифры
        static void Task9()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string result = "";

            foreach (char c in text)
            {
                result += c;
                if (char.IsDigit(c))
                    result += " ";
            }

            Console.WriteLine("Результат: " + result);
        }

        // 10. Увеличить цифры на 1 (9→0)
        static void Task10()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string result = "";

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    int num = int.Parse(c.ToString());
                    num = (num + 1) % 10;
                    result += num.ToString();
                }
                else
                    result += c;
            }

            Console.WriteLine("Результат: " + result);
        }

        // 11. Сначала цифры, потом буквы
        static void Task11()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string digits = "";
            string letters = "";
            string others = "";

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    digits += c;
                else if (char.IsLetter(c))
                    letters += c;
                else
                    others += c;
            }

            Console.WriteLine("Результат: " + digits + letters + others);
        }

        // 12. Преобразовать маленькие буквы в большие
        static void Task12()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string result = text.ToUpper();
            Console.WriteLine("Результат: " + result);
        }

        // 13. Сдвиг букв на 1 позицию
        static void Task13()
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            if (word.Length == 0)
            {
                Console.WriteLine("Пустая строка");
                return;
            }

            string result = word[word.Length - 1] + word.Substring(0, word.Length - 1);
            Console.WriteLine("Зашифрованное слово: " + result);
        }

        // 14. Вывод по 5 цифр в строке
        static void Task14()
        {
            Console.WriteLine("Введите строку цифр:");
            string digits = Console.ReadLine();
            for (int i = 0; i < digits.Length; i += 5)
            {
                int length = Math.Min(5, digits.Length - i);
                Console.WriteLine(digits.Substring(i, length));
            }
        }

        // 15. Увеличить ASCII-коды на 3
        static void Task15()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            string result = "";

            foreach (char c in text)
            {
                result += (char)(c + 3);
            }

            Console.WriteLine("Результат: " + result);
        }

        // 16. Сумма цифр, кратных 3, в 3 строках
        static void Task16()
        {
            Console.WriteLine("Введите 3 строки:");
            string[] lines = new string[3];
            for (int i = 0; i < 3; i++)
            {
                lines[i] = Console.ReadLine();
            }

            foreach (string line in lines)
            {
                Console.WriteLine($"Сумма цифр, кратных 3: {SumDigitsDivisibleBy3(line)}");
            }
        }

        static int SumDigitsDivisibleBy3(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    int num = int.Parse(c.ToString());
                    if (num % 3 == 0)
                        sum += num;
                }
            }
            return sum;
        }

        // 17. Сумма цифр в 2 строках
        static void Task17()
        {
            Console.WriteLine("Введите 2 строки:");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            Console.WriteLine($"Сумма цифр в строке 1: {SumDigits(s1)}");
            Console.WriteLine($"Сумма цифр в строке 2: {SumDigits(s2)}");
        }

        static int SumDigits(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    sum += int.Parse(c.ToString());
            }
            return sum;
        }

        // 18. Количество символов с ASCII >= 70
        static void Task18()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            int count = 0;

            foreach (char c in text)
            {
                if (c >= 70)
                    count++;
            }

            Console.WriteLine($"Количество символов с ASCII >= 70: {count}");
        }

        // 19. Добавить символы справа
        static void Task19()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            char symbol = Console.ReadLine()[0];
            Console.WriteLine("Введите количество:");
            int count = int.Parse(Console.ReadLine());

            AddSymbols(ref text, symbol, count);
            Console.WriteLine("Результат: " + text);
        }

        static void AddSymbols(ref string s, char symbol, int count)
        {
            for (int i = 0; i < count; i++)
                s += symbol;
        }

        // 20. Удалить пробелы
        static void Task20()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            RemoveSpaces(ref text);
            Console.WriteLine("Результат: " + text);
        }

        static void RemoveSpaces(ref string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (c != ' ')
                    result += c;
            }
            s = result;
        }

        // 21. Зеркальное отображение
        static void Task21()
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            MirrorWord(ref word);
            Console.WriteLine("Результат: " + word);
        }

        static void MirrorWord(ref string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new string(arr);
        }

        // 22. Разбить на строки по k символов
        static void Task22()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите k:");
            int k = int.Parse(Console.ReadLine());
            SplitText(text, k);
        }

        static void SplitText(string s, int k)
        {
            for (int i = 0; i < s.Length; i += k)
            {
                int length = Math.Min(k, s.Length - i);
                Console.WriteLine(s.Substring(i, length));
            }
        }

        // 23. Вставить пробелы через каждые n символов
        static void Task23()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k:");
            int k = int.Parse(Console.ReadLine());
            InsertSpaces(ref text, n, k);
            Console.WriteLine("Результат: " + text);
        }

        static void InsertSpaces(ref string s, int n, int k)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                result += s[i];
                if ((i + 1) % n == 0)
                    result += new string(' ', k);
            }
            s = result;
        }

        // 24. Заменить слово А1 на А2
        static void Task24()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите слово A1:");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите слово A2:");
            string a2 = Console.ReadLine();
            ReplaceWord(ref text, a1, a2);
            Console.WriteLine("Результат: " + text);
        }

        static void ReplaceWord(ref string s, string a1, string a2)
        {
            s = s.Replace(a1, a2);
        }
    }
}
