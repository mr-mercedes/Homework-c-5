// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
Console.WriteLine("Тест на сообразительность!");
Console.WriteLine("Ответе на вопрос");
string exitWord = "exit";
string? userUnswer = string.Empty;
while (exitWord != userUnswer)
{
    Console.Write("Введите ответ: ");
    userUnswer = Console.ReadLine();
    if (userUnswer == exitWord)
    {
        Console.WriteLine("А ты сообразительный, тест завершен");
        break;
    }
    else
    {
      Console.WriteLine("Не верно, повторите попытку");  
    }
}