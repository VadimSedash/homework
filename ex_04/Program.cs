// № 4. Найти максимальное из трёх чисел
Console.Write("Введите первое число -> ");
string numberOne = Console.ReadLine();
Console.Write("Введите второе число -> ");
string numberTwo = Console.ReadLine();
Console.Write("Введите третье чилсо -> ");
string numberThree = Console.ReadLine();

int first = int.Parse(numberOne);
int second = int.Parse(numberTwo);
int third = int.Parse(numberThree);
int max = first;

if(second > max)
max = second;
if(third > max)
max = third;

Console.Write($"Наибольшим числом является: {max}");