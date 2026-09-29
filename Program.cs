// int i = 1;
// while (i <= 5)
// {
//     Console.WriteLine(i);
//     i++;
// }

// string input = Console.ReadLine();
// while (input != "stop")
// {
//     Console.WriteLine(input);
//     input = Console.ReadLine();
// }

// do
// {
//     //Тело выполнится мин. 1 раз
// } while (условие);

// int lessonNumber = 1;
// int totalLessons = 5;

// while (lessonNumber <= totalLessons)
// {
//     Console.WriteLine($"Para {lessonNumber}");
//     lessonNumber++;
// }
// Console.WriteLine("Para end");

// Console.WriteLine("Вводите оценки по одной, для завершения введите - 1: ");

// int grade = int.Parse(Console.ReadLine());
// int total = 0;
// while (grade != 1)
// {
//     total++;
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
// }
// Console.WriteLine($"Ввод завершён \n Введено оценок: {total}");

// int sum = 0;
// int count = 0;

// Console.WriteLine("Вводите оценки по одной, для завершения введите - 1: ");

// int grade = int.Parse(Console.ReadLine());
// int max = grade;
// while (grade != 1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
//     if (grade > max) max = grade;
// }

// if (count > 0)
// {
//     Console.WriteLine($"Ср. балл: {(double)sum / count} \n Макс. оценка: {max}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }

string correctPassword = "qwerty123";
int count = 0;
while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine($"Доступ разрешён \nКол-во попыток: {count}");
        break;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
    count++;
}