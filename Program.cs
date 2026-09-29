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

// // do
// // {
// //     //Тело выполнится мин. 1 раз
// // } while (условие);

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

// int grade1 = int.Parse(Console.ReadLine());
// int max = grade1;
// while (grade1 != 1)
// {
//     sum += grade1;
//     count++;
//     grade1 = int.Parse(Console.ReadLine());
//     if (grade1 > max) max = grade1;
// }

// if (count > 0)
// {
//     Console.WriteLine($"Ср. балл: {(double)sum / count} \n Макс. оценка: {max}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }

// string correctPassword = "qwerty123";
// int count1 = 0;
// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine($"Доступ разрешён \nКол-во попыток: {count1}");
//         break;
//     }
//     Console.WriteLine("Неверный пароль, попробуйте снова");
//     count1++;
// }

// string answer;

// do
// {
//     Console.Write("Ведите дату посещения (напр.: 01.09)");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("ДОбавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохр.");


// // A

// int factor1 = 1;
// int factor2 = 1;
// while (factor1 != 11)
// {
//     while (factor2 != 11)
//     {
//         Console.WriteLine($"{factor1} * {factor2} = {factor1 * factor2}");
//         factor2++;
//     }
//     Console.WriteLine();
//     factor2 = 1;
//     factor1++;
// }

// // G

// Console.Write("Введите число(целое): ");
// int num = int.Parse(Console.ReadLine());

// while (true)
// {
//     if (num % 7 == 0)
//     {
//         Console.WriteLine("Число найдено!");
//         break;
//     }
//     num = int.Parse(Console.ReadLine());
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // 5

// int code = 1234;

// int inputCode = int.Parse(Console.ReadLine());

// while (true)
// {
//     if (inputCode == code)
//     {
//         Console.WriteLine("Дверь открыта");
//         break;
//     }
//     inputCode = int.Parse(Console.ReadLine());
// }

// // 6

// int count2 = 0;
// int inputNum = int.Parse(Console.ReadLine());

// while (inputNum != 0)
// {
//     inputNum /= 10;
//     count2++;
// }
// Console.WriteLine($"Кол-во цифр в числе: {count2}");