// В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.


string secretWord = "Ты победитель";
int password = 246;

Console.WriteLine("Сообщение заблокированно, введите пароль");
Console.WriteLine("Подсказка: пароль состоит из трех четных чисел");
int count = 0;
int chance = 3;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите пароль:");
    int userPassword = Convert.ToInt32(Console.ReadLine());
    if (userPassword == password)
    {
        Console.WriteLine($"Пароль введен верно, текст сообщения : *{secretWord}*");
        break;
    }
    else
    {
        count++;
        if (count == 3)
        {
            Console.WriteLine($"Файл заблокирован, пароль введен не верно {count} раза");
            break;
        }
        Console.WriteLine($"Пароль введен не верно, осталось {chance-count} попыток ");
        
    }
}
