// \n добавит новую строку
// \t добавит табуляцию
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
// \" добавит экранированную кавычку
Console.WriteLine("Hello  \"World\"!");
// \\ для вывода обратной косой черты
Console.WriteLine("c:\\source\\repos");
Console.WriteLine("__________");
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine("__________");
//Буквальная литеральная строка @
Console.WriteLine(@"   c:\source\repos   
      (""this is where your code goes"")");
Console.WriteLine("__________");
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");
Console.WriteLine("__________");
// \u добавление закодированных символов
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
Console.WriteLine("__________");
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
Console.WriteLine("__________");
Console.WriteLine("__________");
Console.WriteLine("__________");
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);
Console.WriteLine("__________");
string firstName2 = "Boobs";
string greeting = "Haloo";
string message2 = greeting + " " + firstName2 + "!";
Console.WriteLine(message2);
Console.WriteLine("__________");
//Буквенные литералы и интерполяция строк"
string firstName3 = "Bob";
string greeting2 = "Hello";
Console.WriteLine($"{greeting2} {firstName3}");
Console.WriteLine("__________");
//Буквальные литералы + интеполяция строк
string projectName5 = "First-Project";
Console.WriteLine($@"C:\Output\{projectName5}\Data");
Console.WriteLine("__________");
Console.WriteLine("__________");
Console.WriteLine("__________");
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishMessage = "View English output:";
string path = "c:\\Exercise\\";
string data = "data.txt";
string ruru = "ru-RU";
Console.WriteLine($"{englishMessage}\n\t\t{path}{projectName}{data}");
Console.WriteLine($"{russianMessage}:\n\t\t{path}{projectName}\\{ruru}\\{data}");
