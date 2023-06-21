// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int A = 2;
// int B = 4;

int BaseValue = Promt("Введите основание степени");
int ExpValue = Promt("Введите показатель степени");
ExpResult(BaseValue, ExpValue);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}

void ExpResult (int value, int exp){
if (exp<0) {
Console.WriteLine("Значение показателя степение меньше 0, введите положительное значение");
}
else {
int result = 1;
for (int i = 0; i < exp; i++) 
{
int x = value;
result = result*x;
}
Console.WriteLine($"Число {BaseValue} в натуральной степени {ExpValue} равно: {result}");
}
}
