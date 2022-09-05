int n = new Random().Next(1, 10000);
Console.WriteLine("n = " + n + ", Сумма равна " + Sum(n));
int Sum (int n){
    int result = 0;
    char[] numbers = n.ToString().ToCharArray();
    for (int i = 0; i < numbers.Length; i++)
    {
        result = (int)char.GetNumericValue(numbers[i]) + result;
    }
    return result;
}
