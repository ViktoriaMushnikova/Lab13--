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
