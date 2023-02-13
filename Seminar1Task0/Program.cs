Console.WriteLine("Введите число:");
// считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем чтобы данные не были пустыми 
if (inputNum != null)
{
    //Парсим введенное число
    int number = int.Parse(inputNum);

    //находим квадрат числа
    int outNum = number*number;
    //выводим данные в консоль
    Console.WriteLine("Квадрат числа: "+outNum);
}