// Вид 1  Ничего не принимают, ничего не возвращают
/*void Method1()
{
    Console.WriteLine("Автор ...");
}*/
//Method1();                              // Вызывается так. Если забыть скобки - ошибка

// Вид 2   Что-то принимают, ничего не возвращают
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}*/
//Method2("Текст сообщения");
//Method2(msg: "Текст сообщения");

/*void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;                          // Инкримент; conunt--; - текримент
    }
}*/
//Method21 ("Текст", 4);
//Method21 (msg: "Текст", count: 4);
//Method21 (count: 4, msg: "Новый текст");


// Вид 3  Ничего не принимают, но что-то возвращают
/*int Method3 ()
{
    return DateTime.Now.Year;
}

int year = Method3();*/
//Console.WriteLine(year);

// Вид 4 Что-то принимают, что-то возвращают
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;             // "" -Пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Ту-");
Console.WriteLine(res);*/

/*string Method41(int count, string text)
{
    string result = String.Empty;             // "" -Пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method41(10, "Ту-");
Console.WriteLine(res);*/

// Таблица умножения
/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}*/

// ===== Работа с текстом
// Дан текст. В тексте нужно заменить все пробелы черточками, маленькие буквы "к", большими "К", 
// а большие "С", маленькими "с".

// Ясна задача?

/*string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty";
//             012345
// s[3]  // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);*/

// Сортировка массива

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)              // Выводим элементы массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)            // Сортируем массив по возрастанию
{
    for (int i = 0; i < array.Length - 1; i++)                   // Компенсируем i + 1 во вложенном цикле
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)               // Стартуем со следующего элемента после i
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);