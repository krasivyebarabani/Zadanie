using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Список тестовых случаев
        List<TestCase> testCases = new List<TestCase>
        {
            new TestCase(0, 0.01),     // 0 баллов - 1% скидка
            new TestCase(50, 0.01),    // 50 баллов - 1% скидка
            new TestCase(100, 0.03),   // 100 баллов - 3% скидка
            new TestCase(150, 0.03),   // 150 баллов - 3% скидка
            new TestCase(200, 0.05),   // 200 баллов - 5% скидка
            new TestCase(300, 0.05),   // 300 баллов - 5% скидка
            new TestCase(500, 0.05),   // 500 баллов - 5% скидка
            new TestCase(501, 0.10),    // 501 балл - 10% скидка
            new TestCase(600, 0.10)     // 600 баллов - 10% скидка
        };

        // Проверяем каждый тестовый случай
        foreach (var testCase in testCases)
        {
            double actualDiscount = CalculateDiscount(testCase.Points);
            Console.WriteLine($"Баллы: {testCase.Points}, Ожидаемая скидка: {testCase.ExpectedDiscount * 100}%, Фактическая скидка: {actualDiscount * 100}%");
            Console.WriteLine(actualDiscount == testCase.ExpectedDiscount ? "Тест пройден." : "Тест не пройден.");
            Console.WriteLine();
        }
    }

    static double CalculateDiscount(int points)
    {
        if (points < 100)
        {
            return 0.01; // Скидка 1%
        }
        else if (points < 200)
        {
            return 0.03; // Скидка 3%
        }
        else if (points < 500)
        {
            return 0.05; // Скидка 5%
        }
        else
        {
            return 0.10; // Скидка 10%
        }
    }
}

class TestCase
{
    public int Points { get; }
    public double ExpectedDiscount { get; }

    public TestCase(int points, double expectedDiscount)
    {
        Points = points;
        ExpectedDiscount = expectedDiscount;
    }
}