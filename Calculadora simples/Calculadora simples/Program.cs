using static System.Console;
double x, y, result;
WriteLine("Calculadora simples:\ndigite: x operador y\n");
x = Convert.ToDouble(ReadLine());
string op;
op = ReadLine();
y = Convert.ToDouble(ReadLine());
switch (op)
{
    case "+":
        WriteLine($"Sua operação foi: {x} + {y}");
        result = x + y;
        WriteLine($"Resultado: {result}");
        break;
    case "-":
        WriteLine($"Sua operação foi: {x} - {y}");
        result = x - y;
        WriteLine($"Resultado: {result}");
        break;
    case "*":
        WriteLine($"Sua operação foi: {x} * {y}");
        result = x * y;
        WriteLine($"Resultado: {result}");
        break;
    case "/":
        WriteLine($"Sua operação foi: {x} / {y}");
        result = x / y;
        WriteLine($"Resultado: {result}");
        break;
    default:
        WriteLine("Insira um operador válido.");
        break;
}