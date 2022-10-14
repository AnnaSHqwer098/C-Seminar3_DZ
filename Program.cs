// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine()!;

if ((num.Length < 5) || (num.Length > 5)){
    Console.WriteLine("Введено некорректное число");
}
else if ((num[0] == num[4]) && (num[1] == num[3])) {
    Console.WriteLine($"Число {num} является палиндромом");
}
else {
    Console.WriteLine($"Число {num} не является палиндромом");
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


 Console.WriteLine("Введите координату X точки A: ");
 int Xa = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату Y точки A: ");
 int Ya = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату Z точки A: ");
 int Za = int.Parse(Console.ReadLine()!);

 Console.WriteLine("Введите координату X точки B: ");
 int Xb = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату Y точки B: ");
 int Yb = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату Z точки B: ");
 int Zb = int.Parse(Console.ReadLine()!);

 double AB = Math.Sqrt(Math.Pow((Xa - Xb), 2) + Math.Pow((Ya - Yb), 2) + Math.Pow((Za - Zb), 2));
 Console.WriteLine($"Расстояние между точками в 3D пространстве = {AB:f2}");
 

//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  3 -> 1, 8, 27
//  5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число больше 0: ");
int N = int.Parse(Console.ReadLine()!);
if (N <= 0) {
    Console.WriteLine("Введено некорректное число");
}
else {
    for (int i = 1; i <=N; i++) {
    Console.WriteLine(Math.Pow(i, 3));
    }
}



