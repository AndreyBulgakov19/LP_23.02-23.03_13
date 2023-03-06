// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта
// точка.

// Console.WriteLine($"Введите координаты точки");
// Console.Write("X: ");
// int xCoord = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoord = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xCoord, yCoord);
// string result = quarter > 0 
//                 ? $"Указанные координаты соответствуют четверти {quarter}" 
//                 : "Введены некорректные координаты";

// Console.WriteLine(result);

// int Quarter (int x, int y)
// {
//     if(x > 0 && y > 0) return 1; //x > 0 && y > 0
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return 0;
// }

Math.Sqrt(5);
double res = 5.09987564;
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine(resRound);


// 1   1
// 2   4
// 3   9
// 4   16
// 5   25
// 6   36