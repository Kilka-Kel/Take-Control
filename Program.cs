Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Сначала выводим наш массив");



string [] Str= { "Mon", "Tuesd", "Wednesday", "Thirsday", "Friday", "Saturday","Sun" };
string[] str2 = new string[Str.Length];

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

for (int step = 0;step<Str.Length; step++)
    if(Str[step].Length<4) 
    {
        str2[step]=Str[step];
    }
    else
    {
        str2[step]=string.Empty;
    }

    PrintStr(str2);