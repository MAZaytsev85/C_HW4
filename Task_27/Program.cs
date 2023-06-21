// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//int a = 82;

int Value = Promt("Введите число");
ValueSumm (Value);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}

void ValueSumm (int a) {
int result = 0;
while (a > 0) {
    int b = a % 10;
    result = result + b;
    a = a / 10;
}
Console.WriteLine(result);
}
