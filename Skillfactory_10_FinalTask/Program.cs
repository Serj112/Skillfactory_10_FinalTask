using Skillfactory_10_FinalTask;

public interface ILogger
{
    void Event(string message);
    void Error(string message);
}

public class Logger: ILogger
{
    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }

    public void Event(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
    }
}

public interface IWorker
{
    void Work();
}

public interface ICalculator
{
    int Sum(int a, int b);
}

public class Calculator: ICalculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}

public class Program
{
    static ILogger Logger { get; set; }
    static void Main()
    {
        Logger = new Logger();
        var worker1 = new Worker1(Logger);

        worker1.Work();

        try
        {
            var calculator = new Calculator();

            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Сумма чисел равна: " + ((ICalculator)calculator).Sum(a, b));
        }

        catch
        {
            worker1.Error();
        }
        
    }
}