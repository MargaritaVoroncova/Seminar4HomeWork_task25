// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int userNumberDegree = userNumber;

for(int i = 1; i < degree; i++)
{
    userNumberDegree = userNumberDegree * userNumber;
}
Console.WriteLine($"{userNumber} в степени {degree} равно {userNumberDegree}");