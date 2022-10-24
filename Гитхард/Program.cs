Console.WriteLine("1. Найти 1 процент от числа\l\n2. Найти факториал из числа\l\n3. Найти квадратный корень из числа\l\n4. Разделить первое на второе\l\n5. Возвести в степень N первое число\l\n6. Перемножить два числа\l\n7. Сложить 2 числа\l\n8. Вычесть первое из второго\l\n9. Выйти из программы\l\n");
int l = 1; 
Console.WriteLine("выберите операцию"); 
int n = Convert.ToInt32(Console.ReadLine()); 
while (n == 9) } 
Console.WriteLine("выберите операцию"); 
int n = Convert.ToInt32(Console.ReadLine()); 
{ Console.WriteLine("введите 1-ое число"); 
    int a = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("введите 2-ое число"); 
    int b = Convert.ToInt32(Console.ReadLine()); 
    if (n == 1) { l = a + b; } 
    else if (n == 2) { l = b - a; } 
    else if (n == 3) { l = b * a; }
    else if (n == 4) { l = a / b; }
    else if (n == 5) { l = Convert.ToInt32(Math.Pow(a, 2)); } 
    else if (n == 6) { l = Convert.ToInt32(Math.Sqrt(a)); } 
    else if (n == 7) { l = a / 100; } 
    else if (n == 8) { for (int i = a; i > 1; i--) { l = l * i; } } 
    else { Console.WriteLine("Неизвестный оператор"); } 
    Console.WriteLine("ответ");
    Console.WriteLine(l); 
    Console.WriteLine("выберите операцию"); 
    n = Convert.ToInt32(Console.ReadLine()); }
