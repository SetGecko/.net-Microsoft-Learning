/*string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"Первый: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Второй: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Третий: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Переназначение первого: {fraudulentOrderIDs[0]}");*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
Console.WriteLine($"Первый: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Второй: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Третий: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Переназначение первого: {fraudulentOrderIDs[0]}");

Console.WriteLine($"Присутствует {fraudulentOrderIDs.Length} случа(-я)ев мошенничества для обработки");

/*
string[] names = {"Изя","Пеймон","Инана"};
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"В ячейке {bin} = {items} предметов (Общая сумма: {sum})");
}

Console.WriteLine($"У нас {sum} предмета(ов) на складе");

string[] fraudCalls = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
string callZ = "";
foreach (string call in fraudCalls)
{
    callZ = call;
    if (callZ.StartsWith("B"))
    {
        Console.WriteLine($"{callZ}");
    }
}
