using System;
using System.Linq;

class Tasks
{
    // Задача 1.2: Сумма двух последних цифр числа
    public int sumLastNums(int x)
    {
        int lastDigit = x % 10;
        int secondLastDigit = (x / 10) % 10;
        return lastDigit + secondLastDigit;
    }

    // Задача 1.4: Проверка на "позитивное" число
    public bool isPositive(int x)
    {
        return x > 0;
    }

    // Задача 1.6: Проверка на заглавную букву
    public bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    // Задача 1.8: Проверка, делится ли одно число на другое
    public bool isDivisor(int a, int b)
    {
        return a % b == 0 || b % a == 0;
    }

    // Задача 1.10: Последовательная сумма цифр разряда единиц
    public int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }

    public void multiSumSequence(int[] numbers)
    {
        int result = lastNumSum(numbers[0], numbers[1]);
        for (int i = 2; i < numbers.Length; i++)
        {
            result = lastNumSum(result, numbers[i]);
        }
        Console.WriteLine("Итог: " + result);
    }

    // Задача 2.2: Безопасное деление
    public double safeDiv(int x, int y)
    {
        return y == 0 ? 0 : (double)x / y;
    }

    // Задача 2.4: Сравнение чисел с оператором
    public string makeDecision(int x, int y)
    {
        if (x > y) return $"{x} > {y}";
        else if (x < y) return $"{x} < {y}";
        else return $"{x} == {y}";
    }

    // Задача 2.6: Тройная сумма
    public bool sum3(int x, int y, int z)
    {
        return (x + y == z) || (x + z == y) || (y + z == x);
    }

    // Задача 2.8: Возраст с правильным окончанием
    public string age(int x)
    {
        int lastDigit = x % 10;
        int lastTwoDigits = x % 100;
        if (lastDigit == 1 && lastTwoDigits != 11) return $"{x} год";
        else if ((lastDigit >= 2 && lastDigit <= 4) && !(lastTwoDigits >= 12 && lastTwoDigits <= 14)) return $"{x} года";
        else return $"{x} лет";
    }

    // Задача 2.10: Вывод дней недели
    public void printDays(string x)
    {
        switch (x.ToLower())
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }

    // Задача 3.2: Числа от x до 0
    public string reverseListNums(int x)
    {
        string result = "";
        for (int i = x; i >= 0; i--)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    // Задача 3.4: Возведение в степень
    public int pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    // Задача 3.6: Одинаковость цифр
    public bool equalNum(int x)
    {
        int lastDigit = x % 10;
        while (x > 0)
        {
            if (x % 10 != lastDigit)
            {
                return false;
            }
            x /= 10;
        }
        return true;
    }

    // Задача 3.8: Левый треугольник
    public void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    // Задача 3.10: Угадайка
    public void guessGame()
    {
        Random rand = new Random();
        int secretNumber = rand.Next(0, 10);
        int guess;
        int attempts = 0;
        do
        {
            guess = ReadInt("Введите число от 0 до 9: ");
            attempts++;
            if (guess != secretNumber)
            {
                Console.WriteLine("Вы не угадали, попробуйте снова.");
            }
        } while (guess != secretNumber);
        Console.WriteLine($"Вы угадали число за {attempts} попыток!");
    }

    // Задача 4.2: Поиск последнего вхождения числа в массив
    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    // Задача 4.4: Добавление в массив
    public static int[] Add(int[] arr, int x, int pos)
    {
        // Создаем новый массив с размером на 1 больше
        int[] newArr = new int[arr.Length + 1];
        
        // Копируем элементы в новый массив до позиции вставки
        for (int i = 0; i < pos; i++)
        {
            newArr[i] = arr[i];
        }
        
        newArr[pos] = x; // Вставляем новое значение в заданную позицию
        
        // Копируем оставшиеся элементы
        for (int i = pos; i < arr.Length; i++)
        {
            newArr[i + 1] = arr[i];
        }
        
        return newArr; // Возвращаем новый массив
    }

    // Задача 4.6: Реверс массива
    public static void Reverse(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;
        
        // Меняем местами элементы, пока не дойдем до середины
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    // Задача 4.8: Объединение массивов
    public static int[] Concat(int[] arr1, int[] arr2)
    {
        // Создаем новый массив, длина которого равна сумме длин двух массивов
        int[] result = new int[arr1.Length + arr2.Length];
        
        // Копируем первый массив в результат
        Array.Copy(arr1, 0, result, 0, arr1.Length);
        // Копируем второй массив в результат
        Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
        
        return result; // Возвращаем объединенный массив
    }

    // Задача 4.10: Удаление отрицательных элементов из массива
    public int[] deleteNegative(int[] arr)
    {
        return arr.Where(x => x >= 0).ToArray();
    }

    // Метод для чтения массива с клавиатуры
    public int[] ReadArray(string prompt)
    {
        Console.Write(prompt);
        int size;

        // Проверяем, что размер массива положительное целое число
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.Write("Введите размер массива: ");
        }

        int[] arr = new int[size];
        
        // Чтение каждого элемента массива
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.Write("Введите корректное целое число: ");
            }
        }
        return arr;
    }

    // Вспомогательный метод для безопасного чтения целых чисел
    public int ReadInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
        }
    }

    // Вспомогательный метод для безопасного чтения символов
    public char ReadChar(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadKey().KeyChar;
    }

    // Вспомогательный метод для безопасного чтения строк
    public string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    // Главный метод для запуска программы
    static void Main(string[] args)
    {
        Tasks tasks = new Tasks();

        // Задача 1.2
        int num1 = tasks.ReadInt("Введите число для задачи 1.2 (Сумма двух последних цифр): ");
        Console.WriteLine("Результат: " + tasks.sumLastNums(num1));

        // Задача 1.4
        int num2 = tasks.ReadInt("Введите число для задачи 1.4 (Проверка на позитивное число): ");
        Console.WriteLine("Результат: " + tasks.isPositive(num2));

        // Задача 1.6
        char ch = tasks.ReadChar("Введите символ для задачи 1.6 (Проверка на заглавную букву): ");
        Console.WriteLine("\nРезультат: " + tasks.isUpperCase(ch));

        // Задача 1.8
        int num3 = tasks.ReadInt("Введите первое число для задачи 1.8 (Проверка деления): ");
        int num4 = tasks.ReadInt("Введите второе число для задачи 1.8: ");
        Console.WriteLine("Результат: " + tasks.isDivisor(num3, num4));

        // Задача 1.10
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = tasks.ReadInt($"Введите число {i + 1} для задачи 1.10 (Последовательная сумма): ");
        }
        tasks.multiSumSequence(numbers);

        // Задача 2.2
        int x1 = tasks.ReadInt("Введите первое число для задачи 2.2 (Безопасное деление): ");
        int y1 = tasks.ReadInt("Введите второе число для задачи 2.2: ");
        Console.WriteLine("Результат: " + tasks.safeDiv(x1, y1));

        // Задача 2.4
        int x2 = tasks.ReadInt("Введите первое число для задачи 2.4 (Сравнение чисел): ");
        int y2 = tasks.ReadInt("Введите второе число для задачи 2.4: ");
        Console.WriteLine("Результат: " + tasks.makeDecision(x2, y2));

        // Задача 2.6
        int a = tasks.ReadInt("Введите первое число для задачи 2.6 (Тройная сумма): ");
        int b = tasks.ReadInt("Введите второе число для задачи 2.6: ");
        int c = tasks.ReadInt("Введите третье число для задачи 2.6: ");
        Console.WriteLine("Результат: " + tasks.sum3(a, b, c));

        // Задача 2.8
        int age = tasks.ReadInt("Введите возраст для задачи 2.8 (Правильное окончание): ");
        Console.WriteLine("Результат: " + tasks.age(age));

        // Задача 2.10
        string day = tasks.ReadString("Введите день недели для задачи 2.10 (Вывод дней недели): ");
        tasks.printDays(day);

        // Задача 3.2
        int num5 = tasks.ReadInt("Введите число для задачи 3.2 (Числа от x до 0): ");
        Console.WriteLine("Результат: " + tasks.reverseListNums(num5));

        // Задача 3.4
        int baseNum = tasks.ReadInt("Введите число для задачи 3.4 (Возведение в степень): ");
        int exp = tasks.ReadInt("Введите степень: ");
        Console.WriteLine("Результат: " + tasks.pow(baseNum, exp));

        // Задача 3.6
        int num6 = tasks.ReadInt("Введите число для задачи 3.6 (Одинаковость цифр): ");
        Console.WriteLine("Результат: " + tasks.equalNum(num6));

        // Задача 3.8
        int height = tasks.ReadInt("Введите высоту треугольника для задачи 3.8 (Левый треугольник): ");
        tasks.leftTriangle(height);

        // Задача 3.10
        Console.WriteLine("Запуск игры угадайка (Задача 3.10):");
        tasks.guessGame();

        // Задача 4.2
        int[] arr = tasks.ReadArray("Введите размер");
        int searchNum = tasks.ReadInt("Введите число для задачи 4.2 (Поиск последнего вхождения): ");
        Console.WriteLine("Результат: " + tasks.findLast(arr, searchNum));

        // Задача 4.4: Ввод массива, вставка элемента и вывод нового массива
        int[] array = tasks.ReadArray("Введите размер массива: ");
        Console.Write("Введите значение для вставки: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Введите позицию для вставки: ");
        int position = int.Parse(Console.ReadLine());

        // Проверка корректности позиции
        if (position < 0 || position > array.Length)
        {
            Console.WriteLine("Некорректная позиция. Позиция должна быть в пределах массива.");
        }
        else
        {
            // Вставка элемента в массив
            int[] newArray = Add(array, value, position);
            Console.WriteLine("Новый массив: " + string.Join(", ", newArray));
        }

        // Задача 4.6: Ввод массива, реверс и вывод обратного массива
        int[] arrayToReverse = tasks.ReadArray("Введите размер массива для реверса: ");
        Reverse(arrayToReverse); // Реверс массива
        Console.WriteLine("Обратный массив: " + string.Join(", ", arrayToReverse));

        // Задача 4.8: Ввод двух массивов и их объединение
        int[] array1 = tasks.ReadArray("Введите размер первого массива: ");
        int[] array2 = tasks.ReadArray("Введите размер второго массива: ");
        int[] mergedArray = Concat(array1, array2); // Объединение массивов
        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));

        // Задача 4.10
        int[] arr6 = { 1, 2, -3, 4, -2, 2, -5 };
        int[] filteredArr = tasks.deleteNegative(arr6);
        Console.WriteLine("Результат удаления негативных элементов: [" + string.Join(", ", filteredArr) + "]");
    }
}

