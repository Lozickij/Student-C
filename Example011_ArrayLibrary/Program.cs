void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
   // int position = 0;                   // Не является общим решением, но, в данном случае, подойдет
    int position = -1;                   // Указание значения отличного от 0 решает проблему несуществующих значений
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;                      //  добавляем break, чтобы после певого совпадения процесс останавливался
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;                         // добавляем в массив четверок, для наглядности
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);         // Если вместо 4 указать заведомо несущуствующее значение, программа выведет 0
Console.WriteLine(pos);