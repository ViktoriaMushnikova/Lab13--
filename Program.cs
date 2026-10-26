using System.Dynamic;

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
