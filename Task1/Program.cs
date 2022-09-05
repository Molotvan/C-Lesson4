Random random = new Random();
int a = random.Next(1, 10);
int b = random.Next(1, 10);
Console.WriteLine("a= " + a + ", " + "b= " + b + ", " + " a^b= " + Power(a, b));

int Power(int a, int b){
    int result = 1;
    for(int i = 1; i<=b; i++){
        result = a*result;
    }
    return result;
}