// № 8. Показать четные числа от 1 до N
Console.Write("Введите число (до него будут показаны все четные числа) ->  ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

int chetnoe = 2;
while(chetnoe <= number)
{
   Console.WriteLine(chetnoe);
   chetnoe = chetnoe + 2;
}
