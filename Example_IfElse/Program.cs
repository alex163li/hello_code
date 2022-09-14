Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алексей")
{
    Console.WriteLine("Здравствуй мой господин");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}