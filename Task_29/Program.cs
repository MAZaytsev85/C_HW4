// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

const int LENGHT = 8;
int min = Promt("Введите минимальное число элемента массива");
int max = Promt("Введите максимальное число элемента массива");

ArrGenerate(LENGHT, min, max);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}

void ArrGenerate(int Lenght, int min, int max) 
{
int [] Arr = new int [Lenght];
Random random= new Random ();
for (int i = 0; i < Lenght; i++) 
{
    Arr [i] = random.Next(min, max);
    Console.Write($"{Arr[i]} ");

}
}
