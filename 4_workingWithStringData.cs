// Создание строковых данных, содержащих знаки табуляции, переноса строки и другие специальные символы
// Создание строковых данных, содержащих символы Юникода
// Объединение строковых данных в новое строковое значение с помощью конкатенации
// Объединение строковых данных в новое строковое значение с помощью интерполяции

//вставка переноса строки
// Console.WriteLine("Hello\nWorld");
// вставка табуляции
// Console.WriteLine("Hello\tWorld");
// Экранирование двойных кавычек
// Console.WriteLine("Hello \"World\"!");
// Отображение обратной кавычки
//Console.WriteLine("c:\\source\\repos");

// Буквальная литеральная строка - @
//Console.WriteLine(@"   c:\source\repos
//        (this os where your code goes)");

// Макет приложения
Console.WriteLine("Generating invoices for customer \" ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\tComplete");
Console.WriteLine("Invoice: 1022\tComplete");
Console.WriteLine("\nOutput Idrectory:\t");
Console.WriteLine(@"c:\invoices");

// To generate Japaneese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

// Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// string firstName = "Bob";
// string message = "Hello " + firstName;
// Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
//string message = greeting + " " + firstName + "!";
//Console.WriteLine(message);
Console.WriteLine(greeting + " " + firstName + "!");


// string fristName = "Bob";
// string message = $"Hello {fristName}!";
// Console.WriteLine(message);

// string firstName = "Bob";
// string greeting = "Hello";
// string message = $"{greeting} {firstName}!";
// Console.WriteLine(message);

// string firstName = "Bob";
// string greeting = "Hello";
// Console.WriteLine($"{greeting} {firstName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output:\n\t\tc:\\Excercise\\{projectName}\\data.txt\n");
Console.WriteLine($"{russianMessage}:\n\t\tc:\\Excercise\\{projectName}\\ru-RU\\data.txt");