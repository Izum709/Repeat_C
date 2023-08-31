// Приветствие любимчиков через конструкцию ветвления 
// Функция .ToLower - Перевод вводимых символов в нижний регистр

Console.Write("Введите имя пользователя -> ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура это же Маша");
}
else
{
    Console.Write(" Привет, ");
    Console.Write(username);
    Console.WriteLine(" я думал это Маша");
}
