Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "aidana")
{
    Console.WriteLine("Hooray, its Aidana!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}