// Задача 27: 
// Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.


// Метод читает данные от пользователя
int ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


//Метод считает сумму цифр числа используя остаток от деления
int SummaNumDigRemOfDiv(int num)
{
    int res = 0;
    while (num >0)
    {
        res = res + num%10;
        num = num /10;
    }
    return res;
}


//Начало основного кода

//Вводим данные с консоли
int number = ReadDataStr("Введите положительное, целое число: ");


// Вычисляем сумму методом RemOfDig
DateTime d2 = DateTime.Now;
int summaRemOfDiv = SummaNumDigRemOfDiv(number);


// Печатаем результат: 
PrintData("Сумма цифр числа равна: ", summaRemOfDiv);

