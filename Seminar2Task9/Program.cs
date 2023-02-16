
System.Random numSintezator = new System.Random();


//Вариант 1
int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;
if(firstNum>secondNum)
{
Console.WriteLine("Первое число больше второго"+firstNum+secondNum);
}
else
{
Console.WriteLine(secondNum);

}
