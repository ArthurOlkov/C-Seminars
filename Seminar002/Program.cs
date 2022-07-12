/*int FindBiggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec) return ed;
    else return dec;


}

int number = new Random().Next(10, 100);
int digit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}");
*/

void FindBiggerDigitVoid(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int max;

    if (ed > dec) max = ed;
    else max = dec;
    Console.WriteLine(max);
}

FindBiggerDigitVoid(38);