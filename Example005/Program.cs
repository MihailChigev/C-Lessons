Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Oh this is Masha");
}
else
{
    Console.Write("Hellow,  ");
    Console.WriteLine(username);
}