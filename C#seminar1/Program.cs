/*
// Задача 1. Возвести число в квадрат.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Result is " + num*num);


// Задача 2. Программа принимает 2 числа и проверяет явл., ли первое квадратом второго

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if(num1 == quad)
{
Console.WriteLine("First number is a quad of second number");
}
else
{
 Console.WriteLine("First number is not a quad of second number");   
}


// Задача 3. Пользователь вводит номер дня недели - выводится день недели

Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1)
{
    Console.WriteLine("Incorrect number of day!");
}
else
{
    if(day == 1)
    Console.WriteLine("It's Monday");
    if(day == 2)
    Console.WriteLine("It's Tuesday");
}


// Задача 4. Программа принимает на входе число n. На выходе показывает все целые в промежутке от -n до n. 

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if(num < 0)
{
    current = num;
    num = num * (-1);
}
else
{
    current = -1 * num;
}
while(current <= num)
{
  Console.Write(current + " ");
  current++;  
}


// Задача 5. Программа принимает трехзначное число и выводит 3-е число.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
{
Console.WriteLine("Incorrect number");
}
else
{
    int a = num % 10;
    Console.WriteLine("Resulted number is " + a);
}


// Задача 6. Программа выводит случайное число из промежутка от 10 до 99. Выводит наибальшее число из двухзначного. 

void ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstNum = num/10;
    int secondNum = num%10;

    Console.Write(num + " -> ");

    if(firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}
ShowNumber();


// Задача 7. При вводе трехзначного числа, программа выводит первое и третье число, упуская второе.

void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int num1 = num/100;
    int num2 = num%10;
    int num3 = num1*10+num2;

    Console.Write(num3);
}

ReduceNumber();



// Задача 8. Программа принимает на вход 2 числа и проверяет делится ли одно на второе.

void IfMultiple()
{
    Console.Write("Input first number ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number ");
    int num2 = Convert.ToInt32(Console.ReadLine());
if(num1%num2 == 0)
{
    Console.Write(num1 + " is multiple of " + num2);
}
else
{
    Console.Write(num1 + " is NOT multiple of " + num2);
}
}
IfMultiple();


// Задача 9. Программа принимает на вход число и проверяет делится ли число на 7 и 23.

void IfMultiple(int num)
{
    if(num%7 == 0 && num%23 == 0)
    {
        Console.Write(num + "is multiple");
    }
    else
    {
       Console.Write(num + " is NOT multiple "); 
    }
}

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
IfMultiple(num);



// Задача 10. Принимает на вход 2 числа и проверяет является ли первое квадратом второго. 

// 1-й вариант

void Square()
{
    Console.Write("Input first number ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 == num2 * num2)
    {
        Console.Write(num1 + " is square " + num2);
    }
    else
    {
        Console.Write(num1 + " is NOT square " + num2);
    }
}
Square();

*/

// 2-й вариант

void Square(int n, int m)
{
if (n == m * m)
{
 Console.Write(n + " is square " + m);
}
else
{
  Console.Write(n + " is NOT square " + m);  
}
}
 Console.Write("Input first number ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number ");
    int num2 = Convert.ToInt32(Console.ReadLine());
Square(num1, num2);