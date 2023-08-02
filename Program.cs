





void print(string[] arr) 
{ 
    //foreach (var item in arr)
        Console.WriteLine(string.Join(" ", arr));
}

string[] filling(string[] test_arr) // заполнение массива произвольными параметрами пользователем
{
    Console.Clear();
    Console.WriteLine("Заполните текстовый массив: ");
    for (int i = 0; i < test_arr.Length; ++i)
    {
        test_arr[i] = Console.ReadLine();
    }
    return test_arr;
}

void check_arr(string[] test_arr) //проверка основного массива на колличчество строк с нужными параметрами
{
    string[] temp = new string[0];

    int i = 0;
    foreach (var item in test_arr)
    {
        if (item.Length > 3)
            continue;
        else 
        {
            ++i;
            temp = new string[i]; // в дальнейшем это массив с новыми параметрами. Идет новое объявление участка памяти с нужным колличеством байт
        }
    }
    temp = record(test_arr, temp); 
    print(temp);
}

string[] record(string[] test_arr, string[] temp) // запись нужных параметров в новый массив
{
    int i = 0;
    foreach (var item in test_arr)
    {
        if (item.Length > 3)
            continue;
        else
        {
            temp[i] = item;
            ++i;
        }
    }
    return temp;
}





Console.WriteLine("Какое колличество слов вы хотите ввести в массив?");
if (int.TryParse(Console.ReadLine(), out int size))
{
    string[] test_arr = new string[size];

    test_arr = filling(test_arr);
    check_arr(test_arr);
}
else
    Console.WriteLine("Увы, ты ввел не числовое значение. Боги будут благосклонны в следующий раз");
