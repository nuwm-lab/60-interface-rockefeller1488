using System;

// Абстрактний клас для дробово-лінійної функції
abstract class AbstractFractionalLinearFunction
{
    protected double a1, a0, b1, b0;

    // Конструктор для ініціалізації коефіцієнтів
    public AbstractFractionalLinearFunction(double a1, double a0, double b1, double b0)
    {
        this.a1 = a1;
        this.a0 = a0;
        this.b1 = b1;
        this.b0 = b0;
        Console.WriteLine("AbstractFractionalLinearFunction Constructor");
    }

    // Абстрактний метод для виведення коефіцієнтів
    public abstract void DisplayCoefficients();

    // Абстрактний метод для обчислення значення функції в точці x0
    public abstract double CalculateValue(double x0);

    // Деструктор
    ~AbstractFractionalLinearFunction()
    {
        Console.WriteLine("AbstractFractionalLinearFunction Destructor");
    }
}

// Батьківський клас для дробово-лінійної функції
class FractionalLinearFunction : AbstractFractionalLinearFunction
{
    public FractionalLinearFunction(double a1, double a0, double b1, double b0)
        : base(a1, a0, b1, b0)
    {
        Console.WriteLine("FractionalLinearFunction Constructor");
    }

    // Реалізація абстрактного методу для виведення коефіцієнтів
    public override void DisplayCoefficients()
    {
        Console.WriteLine($"a1 = {a1}, a0 = {a0}, b1 = {b1}, b0 = {b0}");
    }

    // Реалізація абстрактного методу для обчислення значення функції в точці x0
    public override double CalculateValue(double x0)
    {
        return (a1 * x0 + a0) / (b1 * x0 + b0);
    }

    // Деструктор
    ~FractionalLinearFunction()
    {
        Console.WriteLine("FractionalLinearFunction Destructor");
    }
}

// Похідний клас для розширення функціональності
class AdvancedFractionalLinearFunction : AbstractFractionalLinearFunction
{
    public AdvancedFractionalLinearFunction(double a1, double a0, double b1, double b0)
        : base(a1, a0, b1, b0)
    {
        Console.WriteLine("AdvancedFractionalLinearFunction Constructor");
    }

    // Реалізація абстрактного методу для виведення коефіцієнтів
    public override void DisplayCoefficients()
    {
        Console.WriteLine($"Advanced Coefficients - a1: {a1}, a0: {a0}, b1: {b1}, b0: {b0}");
    }

    // Реалізація абстрактного методу для обчислення значення функції в точці x0
    public override double CalculateValue(double x0)
    {
        return (a1 * x0 * x0 + a1 * x0 + a0) / (b1 * x0 * x0 + b1 * x0 + b0);
    }

    // Деструктор
    ~AdvancedFractionalLinearFunction()
    {
        Console.WriteLine("AdvancedFractionalLinearFunction Destructor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо користувача, який об'єкт створити
        Console.WriteLine("Choose an option (1 - Regular, 2 - Advanced): ");
        char userChoose = Console.ReadKey().KeyChar;
        Console.WriteLine();

        AbstractFractionalLinearFunction flf;  // Показник на абстрактний клас

        if (userChoose == '1')
        {
            // Створюємо об'єкт базового класу
            flf = new FractionalLinearFunction(1, 2, 3, 4);
        }
        else
        {
            // Створюємо об'єкт похідного класу
            flf = new AdvancedFractionalLinearFunction(1, 2, 3, 4);
        }

        // Викликаємо методи через показник на абстрактний клас
        flf.DisplayCoefficients();
        Console.WriteLine($"Value at x0 = 2: {flf.CalculateValue(2)}");

        // Завершення роботи програми
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
