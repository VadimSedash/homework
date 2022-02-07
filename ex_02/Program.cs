// №2. Даны 2 числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
string firstNumber = Console.ReadLine();
Console.Write("Введите второе число: ");
string secondNumber = Console.ReadLine();

int first = int.Parse(firstNumber);
int second = int.Parse(secondNumber);

if(first > second)
Console.Write($"Наибольшее число -> {first}. Наименьшее число -> {second}");
else
Console.Write($"Наибольшее число -> {second}. Наименьшее число -> {first}");