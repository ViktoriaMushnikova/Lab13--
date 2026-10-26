using System.ComponentModel;
using System.Dynamic;

/*
Console.WriteLine("Шаг 1. Метод без параметров");

PrintHeader();
PrintHeader();
Console.WriteLine("Основная Часть программы");
PrintFooter();

void PrintHeader() {
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("0_0");
    Console.WriteLine("Дата формирования отчёта");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("Конец программы");
    Console.WriteLine("X_X");
}

Console.WriteLine("Шаг 2. Метод с параметрами");

void PrintStudentCard (string name, int age, string numberGroup)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {numberGroup}");
}
PrintStudentCard("Егор", 18, "ISP-251");
PrintStudentCard("Валерия", 17, "ISP-252");


Console.WriteLine("Шаг 3. Метод, возвращающий значение");

double CalculateScholarship(double baseAmount, double bonusPercent)
{
    return baseAmount + baseAmount * bonusPercent / 100;
}
bool IsEligibleForBonus(double averageGrade)
{
    return averageGrade >= 4.5;
}
double averageGrade = 4.1;
if (IsEligibleForBonus(averageGrade))
{
    double scholarshipBonus = CalculateScholarship(2000, 15);
    Console.WriteLine(scholarshipBonus);
} else
{
    Console.WriteLine(2000);
}

Console.WriteLine("Шаг 4. Массив как параметр");

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;

}
int CountFives(int[] grades) {
    int total = 0;
    foreach (int grade2 in grades)
    {
        if (grade2 == 5)
        {
            total += 1;
        }
    }
    return total;   
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int gradeFives = CountFives(grades);
Console.WriteLine($"Средний балл: {average}, количество пятёрок: {gradeFives}");
*/
/*
static void Main()
    {
        Console.WriteLine(Add(2, 3));
        Console.WriteLine(Add(2.5, 3.5));
        Console.WriteLine(Add(2, 3, 4));
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    static double Add(double a, double b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}
*/

Console.WriteLine("Задача А");

void PrintDivider()
{
    Console.WriteLine("--");
}
Console.WriteLine("Строка разделитель 1");
PrintDivider();
Console.WriteLine("Строка разделитель 2");
PrintDivider();
Console.WriteLine("Строка разделитель 3");


Console.WriteLine("Задача Б");

void PrintPerson(string name1, int age1)
{
    Console.WriteLine($"Имя: {name1}, возраст: {age1}");
}
PrintPerson("Игорь", 13);
PrintPerson("Ария", 19);

Console.WriteLine("Вариант 1");
void PrintSeparator()
{
    Console.WriteLine("--");
}
Console.WriteLine("Строка разделитель 1");
PrintSeparator();
Console.WriteLine("Строка разделитель 2");
PrintSeparator();
Console.WriteLine("Строка разделитель 3");
PrintSeparator();
Console.WriteLine("Конец");


Console.WriteLine("Вариант 8");
double CelsiusToFahrenHeit(double celsius)
{
    return celsius * 9.0 / 5.0 + 32;
}
double tempCelsius = 32.5;
double tempFahrenHeit = CelsiusToFahrenHeit(tempCelsius);
Console.WriteLine($"Температура в Цельсиях: {tempCelsius}, температура в Фаренгейтах: {tempFahrenHeit}");