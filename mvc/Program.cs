class Program
{
    public static void Main(string[] args){
        Console.WriteLine("Arithmatic Calculation");
        int a = 20;
        int b = 10; 
        int sum, mul, rem, sub = 0;
        float div;
        sum = a+b;
        mul = a*b;
        rem = a%b;
        sub = a-b;
        div = a/b;

        Console.WriteLine("the value is: "+div);
        Console.WriteLine("the value is: "+mul);
        Console.WriteLine("the value is: "+rem);
        Console.WriteLine("the value is: "+sum);
        Console.WriteLine("the value is: "+sub);

    }
}