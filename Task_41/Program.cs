// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void mas(int m)
{
for (int i = 0; i < m; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int count(int[] Array)
{
int i=0;
int count = 0;
while (i < Array.Length)
{
if(Array[i]>0)
count = count + 1;
i = i + 1;
}
return count;
}

mas(m);
Console.Write($"Количество чисел больше 0: {count(Array)}");