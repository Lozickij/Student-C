using System.Linq; // Встр. модуль. Скорее всего понадобится.

string text = "(1,2) (2,3) 4,5) (6,7)"
              .Replace("(", "")
              .Replace(")", "")   // Убираем ненужные скобки.
              ;
Console.WriteLine(text);

var data = text.Split(" ")  // var - обозначает не явный тип; Split(" ") - встр. делает разбивку 
                .Select(item => item.Split(','))   // с учетом разделяющего символа. Здесь пробел и запятая.
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                //.Where(e => e.x % 2 == 0)       // Можно добавить условий.
                .Select(point => (point.x * 10, point.y + 10))   
                .ToArray();  // полученные данные превратим в массив, для наглядности.

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    /*for (int k = 0; k < data[i].Length; k++)
    {
        Console.WriteLine(data[i][k]);
    }*/                                             // Вместо этого for мы создали массив картежей .Select(e => ...
    //Console.WriteLine();                            // Теперь это уже числа!
    //Console.WriteLine(data[i].Item1*10);

}


