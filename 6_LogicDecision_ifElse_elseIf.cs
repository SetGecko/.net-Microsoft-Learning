string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);
if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
Console.WriteLine("_______________");
//внутри условия if для добавления или используется || и для И - &&

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Бросок кубиков:  {roll1} + {roll2} + {roll3} = {total}");

//внутри условия if для добавления или используется ||

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Вы выбросили тройник! +6 бонуса!");
        total += 6;
    }
    else
    {
        Console.WriteLine("Вы выбросили дубль! +2 бонуса!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("Вы выиграли машину!");
}
else if (total >= 10)
{
    Console.WriteLine("Вы выиграли ноутбук!");
}
else if (total == 7)
{
    Console.WriteLine("Вы выиграли путешествие на двоих!");
}
else
{
    Console.WriteLine("Вы выиграли котёночка!");
}
Console.WriteLine("_______________");
Console.WriteLine("_______________");
Console.WriteLine("_____Задача____");
Console.WriteLine("_______________");
Console.WriteLine("_______________");
//Если срок действия подписки пользователя истекает через 10 дней или меньше,
// отображается следующее сообщение:
// Your subscription will expire soon. Renew now!

// Если срок действия пользовательской подписки истекает самое позднее
// через 5 дней, должны отображаться следующие сообщения:
// Your subscription expires in x days.
// Renew now and save 10%!
// Обязательно замените x значением переменной daysUntilExpiration

//Если срок действия пользовательской подписки истекает через 1 день, 
// должно отображаться следующее сообщение:
// Your subscription expires within a day!
// Renew now and save 20%!

// Если срок действия подписки пользователя уже истек, 
// отображается следующее сообщение:
// Your subscription has expired.
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if ((daysUntilExpiration <= 10)&& (daysUntilExpiration >= 6))
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if ((daysUntilExpiration <= 5) && (daysUntilExpiration >= 2))
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine("Renew now and save 10%!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save 20%!");
}
else if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired.");
}
