Console.WriteLine("Выберите номер программы которую хотите запустить: \r\n1 - Игра \"Угадай число\"\r\n2 - Таблица умножения\r\n3 - Вывод делителей числа\r\n4 - выход");
bool isListening = true;
do
{
    Console.WriteLine("Введите номер команды:");
    int answer = Convert.ToInt16(Console.ReadLine());
    if (answer == 1)
    {
        bool isListening1 = true;
        Random rnd = new Random();
        int value = rnd.Next(0, 100);
        do
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == value)
            {
                Console.WriteLine("Молодец, ты угадал число!");
                isListening1 = false;
            }
            else if (number > value)
            {
                Console.WriteLine("Попробуй взять меньше");
            }
            else
            {
                Console.WriteLine("Попробуй взять больше");
            }
        } while (isListening1 == true);

    }
    else if (answer == 2) 
    {
        int n = 5;
        int m = 6;
        int col = 0;
        int row = 0;
        int[,] a = new int[n, m];
        for (int i = 0; i < n * m; i++)
        {
            if (i != 0 && i % n == 0) col++;
            a[row, col] = (row + 1) * (col + 1);
            Console.WriteLine("{0} x {1} = {2}", row + 1, col + 1, a[row, col]);
            row++;
            if (row >= n)
            {
                row = 0;
                Console.WriteLine();
            }
        }
    }
} while (isListening == true);