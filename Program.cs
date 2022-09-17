Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Сначала выводим наш массив");



string [] Str= { "Mon", "Tuesd", "Wednesday", "Thirsday", "Friday", "Saturday","Sun" };


void PrintStr(string[] coll)//печатаем массив
{
    int lenghtPrint = coll.Length;
    int indexPrint = 0;
    while (indexPrint < lenghtPrint)
    {
        System.Console.Write($"{coll[indexPrint]} ");
        indexPrint++;
    }
        System.Console.WriteLine();
}

PrintStr(Str);

