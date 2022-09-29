using System.Runtime.Intrinsics.X86;

Console.WriteLine("Выберите номер программы которую хотите запустить: " +
 "\r\n1 - Игра \"Угадай число\"\r\n" +
    "2 - Таблица умножения\r\n" +
    "3 - Вывод делителей числа\r\n" +
    "4 - выход");
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
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write((i * j) + "\t");
            }
            Console.WriteLine();
        }
    }
    else if (answer == 3)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string c = " ";
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                c += i + " ";   
            }
        }
        Console.WriteLine(c);
    }
    else if (answer == 4)
    {
        isListening = false;
    }
} while (isListening == true);