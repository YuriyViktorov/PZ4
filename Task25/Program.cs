//Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int Prompt(string message)
{
System.Console.Write (message); //Выводим приглашение KO вводу
string readInput = System.Console.ReadLine()?? "0"; // Вводим значение
int result = int.Parse(readInput); //приводим к числу

return result; //возвращаем результат
}
int Power (int powerBase, int exponent)
{

    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }

    return power;
}
bool ValidateExponent (int exponent)
{
if (exponent < 0)
{
System.Console.WriteLine ("Показатель He должен быть меньше нуля");
return false;
}

return true;
}

int powerBase = Prompt ("Введите основание: ");

int exponent = Prompt ("Введите показатель: ");

if (ValidateExponent (exponent) )

{
System.Console.WriteLine ($"Число {powerBase} в степени {exponent} равно {Power (powerBase, exponent)}");

}

