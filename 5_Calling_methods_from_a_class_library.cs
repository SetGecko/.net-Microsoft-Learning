//В следующем методе генерируется и выводится на консоль 
//случайное число, которое моделирует результат броска кубика.

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
Console.WriteLine(dice);

// 1.создается новый экземпляр класса System.Random из библиотеки классов .NET
// 2. Во второй строке кода вызывается метод Next() объекта dice, 
// в который передаются два входных параметра, 
// определяющие минимальную и максимальную величину генерируемого 
// случайного числа. Метод Next() возвращает значение, 
// которое сохраняется в переменной roll
// 3. В третьей строке кода вызывается метод WriteLine(), 
// который выводит значение переменной roll на консоль.
Console.WriteLine("______________________________");
Console.WriteLine("Двойной бросок для монополии");
Random dice2 = new Random();
Random dice3 = new Random();
int rollM1 = dice2.Next(1, 7);
int rollM2 = dice3.Next(1, 7);
int move1 = (rollM1 + rollM2);
Console.WriteLine("Выпало: " + rollM1 + " и " + rollM2);
Console.WriteLine("Можно сходить на " + move1 + " ходов");
Console.WriteLine("______________________________");
// Метод Console.WriteLine() не использует значения, которые хранятся в памяти
// является СТАТИЧЕСКИМ
// методы с отслеживанием состояния и возможность изменения переменных
// называются МЕТОДАМИ ЭКЗЕМПЛЯРА
// для вызова методов с отслеживанием состояния сначала необходимо создать
// экземпляр класса, чтобы обеспечить методам доступ к сведениям о состоянии
// молчаливые методы - VOID
// Перегруженный метод - это метод который на вход для обработки может 
// получать разные параметры, данные.Console.WriteLine(); как пример
// Ниже 3 перегруженные версии Random.Next() 
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);
Console.WriteLine($"Первый бросок: {roll1}");
Console.WriteLine($"Второй бросок: {roll2}");
Console.WriteLine($"Третий бросок: {roll3}");
Console.WriteLine("______________________________");
Console.WriteLine("________Задача________________");
Console.WriteLine("______________________________");
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
//
// Console.WriteLine(largerValue);
// заполнить отсутствующую строку кода, в которой вызывается метод класса Math
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = System.Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
