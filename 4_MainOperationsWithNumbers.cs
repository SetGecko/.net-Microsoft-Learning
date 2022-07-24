int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
string firstName = "Bob";
int widgetsSold = 7;
//Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
//Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

//При делении двух значений типа int все десятичные разряды результата после запятой будут усечены
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Сумма: " + sum);
Console.WriteLine("Разница: " + difference);
Console.WriteLine("Умножение: " + product);
// int может отдать только целочисленное деление
Console.WriteLine("Деление: " + quotient);
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Десятичное деление: " + decimalQuotient);
//Приведение int к decimal
int first2 = 7;
int second2 = 5;
decimal quotient2 = (decimal)first2 / (decimal)second2;
Console.WriteLine(quotient2);
//Выяснение целочисленного остатка от деления
Console.WriteLine("Остаток от деления 200 / 5: " + (200 % 5));
Console.WriteLine("Остаток от деления 7 / 5: " + (7 % 5));
Console.WriteLine("Если остаток равен 0, значит, делимое делится на делитель.");
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

int value10 = 1;
value10 = value10 + 1;
Console.WriteLine("Первый инкремент: " + value10);
value10 += 1;
Console.WriteLine("Второй инкремент: " + value10);
value10++;
Console.WriteLine("Третий инкремент: " + value10);
value10 = value10 - 1;
Console.WriteLine("Первый декремент: " + value10);
value10 -= 1;
Console.WriteLine("Второй декремент: " + value10);
value10--;
Console.WriteLine("Третий декремент: " + value10);

int value11 = 1;
value11++;
Console.WriteLine("First: " + value11);
Console.WriteLine("Second: " + value11++);
Console.WriteLine("Third: " + value11);
Console.WriteLine("Fourth: " + (++value11));
Console.WriteLine("__________");
Console.WriteLine("__________");
Console.WriteLine("__________");
int fahrenheit = 94;
//The temperature is 34.444444444444444444444444447 Celsius.
decimal drob = 5m / 9;
int celsium0 = fahrenheit - 32;
decimal celsium = (decimal)celsium0 * (decimal)drob;
//Console.WriteLine(drob);
Console.WriteLine(celsium);
Console.WriteLine("__________");
Console.WriteLine("__________");
Console.WriteLine("__________");
