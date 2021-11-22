string[] array = { "пн", "вт", "ср", "чт", "пт", "сб", "вск"};

Console.Write("Введите номер дня недели:");

int Dayofweek = int.Parse(Console.ReadLine());

Console.WriteLine(array [Dayofweek-1]);

if (Dayofweek > 7 || Dayofweek < 1)
{
    Console.Write("Неверный номер дня в недели");
}
else
{
    Console.WriteLine(array [Dayofweek-1]);
}