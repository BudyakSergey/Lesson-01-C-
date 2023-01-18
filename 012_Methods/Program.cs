// вид 1
void Method1 ()
{
    Console.WriteLine("Автор Будяк СС");
}
Method1 ();

// вид 2
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2 (msg: "Текст сообщения");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine (msg);
        i++;
    }
}
// Method21 ("Текст", 4); 
// одинаковое написание
// Method21 (msg: "Текст", count: 4);
Method21 (count: 4, msg: "Текст новый");

// вид 3
int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3 ();
Console.WriteLine(year);

// вид 4
string Method4 (int count, string text)
{
//     int i = 0;
     string result = String.Empty; // String.Empty - пустая строка
//     while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
// этот же цикл через for
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4 (10, "Asdf");
Console.WriteLine(res); 

// таблица умножения на экран
// цикл в цикле
 for (int a = 2; a <= 10; a++)
 {
    for (int b = 2; b <= 10; b++)
    {
        Console.WriteLine ($" {a} * {b} = {a*b}");
    }
    Console.WriteLine ();
 }
/* Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”. */

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty";
//             012345
// s[3] = r
// обратились к конкретному значению в позиции текста
string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int d = 0; d < lenght; d++)
    {
        if (text[d]  == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[d]}";
    }

    return result;
}
string newText = Replace(text, ' ', '/');
Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace(newText, 'к', 'К');
Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace(newText, 'С', 'с');
Console.WriteLine (newText);

// упорядочить массив
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };
// метод вывода массива на экран
void PrintArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine ();
}
// метод сортировки
void SelectionSort (int [] array)
{
        for (int i = 0; i < array.Length-1; i++)
    {
        int minPosotion = i;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array [j] < array[minPosotion]) minPosotion = j;
            }


        int tempPosition = array [i];
        array [i] = array [minPosotion];
        array [minPosotion]= tempPosition;
    }
    Console.WriteLine ();
}

PrintArray (arr);
SelectionSort (arr);
PrintArray (arr);