Console.Write("введите имя пользователя  ");
string userName = Console.ReadLine ();
if (userName.ToLower() == "маша")
{
    Console.Write ("Ура! Это же МАША!");
}
else
{
    Console.Write ("Привет, ");
    Console.Write (userName);
}