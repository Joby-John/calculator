// See https://aka.ms/new-console-template for more information
Console.WriteLine("And this is a simple calculator\n");
Console.Write("Enter first number ");
double firstnum = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the operator ");
string op = Console.ReadLine();
Console.Write("Enter second number");
double secondnum = Convert.ToDouble(Console.ReadLine());
switch(op)
{
    case "+":
        Console.WriteLine("Result : " + (firstnum + secondnum));
        break;
    case "-":
        Console.WriteLine("Result : " + (firstnum - secondnum));
        break;
    case "/":
        Console.WriteLine("Result : " + (firstnum / secondnum));
        break;
    case "*":
        Console.WriteLine("Result : " + (firstnum * secondnum));
        break;
    case "%":
        Console.WriteLine("Result : " + (firstnum % secondnum));
        break;
        default:
        Console.WriteLine("Enter a valid operator");
        break;
}