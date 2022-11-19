/*Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username == "Маша")
{
    Console.WriteLine("Ура-а, это же МАША!"); 
}
else
{
    Console.Write("Привет,  ");
    Console.WriteLine(username);
}*/

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура-а, это же МАША!"); 
}
else
{
    Console.Write("Привет,  ");
    Console.WriteLine(username);
}
