namespace group_project_3;

class Program
{
    static void Main(string[] args)
    {
        // Part 1

        // E1
        Console.WriteLine("Part 1 - E1 Start");
        P1E1();
        Console.WriteLine("\nPart 1 - E1 End");

        // E4
        Console.WriteLine("Part 1 - E4 Start");
        P1E4();
        P1E4();
        Console.WriteLine("\nPart 1 - E4 End");

        // E6
        Console.WriteLine("Part 1 - E6 Start");
        P1E6DisplaySineTable();
        Console.WriteLine("\nPart 1 - E6 End");

        // Part 2

        // E1
        Console.WriteLine("Part 2 - E1 Start");
        P2E1(numberOfStars: 0);
        P2E1(numberOfStars: 5);
        P2E1(numberOfStars: 10);
        Console.WriteLine("\nPart 2 - E1 End");

        // E4
        Console.WriteLine("Part 2 - E4 Start");
        P2E4(price: 100, provinceCode: "ON");
        P2E4(price: 100, provinceCode: "on");
        P2E4(price: 100, provinceCode: "QC");
        P2E4(price: 100, provinceCode: "BC");
        P2E4(price: 100, provinceCode: "");
        Console.WriteLine("\nPart 2 - E4 End");

        // E7
        Console.WriteLine("Part 2 - E7 Start");
        P2E7DisplaySineTable(0.50, 0.03, 10);
        Console.WriteLine("\nPart 2 - E7 End");

        // Part 3

        // E1
        Console.WriteLine("Part 3 - E1 Start");
        Console.WriteLine(P3E1CalculateDifference(5, 12));
        Console.WriteLine(P3E1CalculateDifference(25, 2));
        Console.WriteLine(P3E1CalculateDifference(100, 50));
        Console.WriteLine("\nPart 3 - E1 End");

        // E4
        Console.WriteLine("Part 3 - E4 Start");
        Console.WriteLine(P3E4CalculateCommission(900));
        Console.WriteLine(P3E4CalculateCommission(1000));
        Console.WriteLine(P3E4CalculateCommission(1001));
        Console.WriteLine(P3E4CalculateCommission(2000));
        Console.WriteLine("\nPart 3 - E4 End");

        // E7
        Console.WriteLine("Part 3 - E7 Start");
        Console.WriteLine(P3E7HeronsFormula(5.83, 4.24, 8.00));
        Console.WriteLine("\nPart 3 - E7 End");

        // Part 4

        // E1
        Console.WriteLine("Part 4 - E1 Start");
        int x = 5;
        P4E1DoubleIt(ref x);
        Console.WriteLine(x);
        P4E1DoubleIt(ref x);
        Console.WriteLine(x);
        Console.WriteLine("\nPart 4 - E1 End");

        // E4
        Console.WriteLine("Part 4 - E4 Start");
        int a, b, sum, difference;
        a = 5;
        b = 10;
        P4E4(a, b, out sum, out difference);
        Console.WriteLine($"Call 1 - a: {a}, b: {b}, sum: {sum}, difference: {difference}");
        a = 15;
        b = 20;
        P4E4(a, b, out sum, out difference);
        Console.WriteLine($"Call 2 - a: {a}, b: {b}, sum: {sum}, difference: {difference}");
        a = 25;
        b = 30;
        P4E4(a, b, out sum, out difference);
        Console.WriteLine($"Call 3 - a: {a}, b: {b}, sum: {sum}, difference: {difference}");
        Console.WriteLine("\nPart 4 - E4 End");


        // Part 5

        // E1
        Console.WriteLine("Part 5 - E1 Start");
        P5E1DisplayIntArray(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("\nPart 5 - E1 End");

        // E2
        Console.WriteLine("Part 5 - E2 Start");
        P5E1DisplayIntArray(P5E2GenerateRandomIntArray(15, 10));
        P5E1DisplayIntArray(P5E2GenerateRandomIntArray(10, 30));
        P5E1DisplayIntArray(P5E2GenerateRandomIntArray(30, 100));
        Console.WriteLine("\nPart 5 - E2 End");

        // E4
        Console.WriteLine("Part 5 - E4 Start");
        P5E1DisplayIntArray(P5E4CalculateDigitFrequencies(P5E2GenerateRandomIntArray(10, 9)));
        Console.WriteLine("\nPart 5 - E4 End");
    }

    static void P1E1()
    {
        Console.WriteLine("name: Carlos");
        Console.WriteLine("school: Centennial College");
        Console.WriteLine("program: Software Engineering Technology");
        Console.WriteLine("favorite course: Prorgamming 1");
    }

    static void P1E4()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = (height * baseOfTriangle) / 2;
        Console.WriteLine($"The area of the triangle is {area}");
    }

    static void P1E6DisplaySineTable()
    {
        Console.Write("Enter the start value: ");
        double startValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the step size: ");
        double stepSize = Convert.ToDouble(Console.ReadLine());

        int counter = 0;
        Console.WriteLine($"{"x",3}  {"sin(x)",9}");
        while (counter < 10)
        {
            double sine = Math.Sin(startValue);
            Console.WriteLine($"{startValue,5:F4}  {sine,5:F4}");
            startValue += stepSize;
            counter++;

        }
    }

    static void P2E1(int numberOfStars)
    {
        for (int i = 0; i < numberOfStars; i++)
        {
            Console.Write("*");
        }
    }

    static void P2E4(int price, string provinceCode)
    {
        provinceCode = provinceCode.ToUpper();

        double tax = 0;
        if (provinceCode == "ON") { tax = 0.13; }
        if (provinceCode == "QC") { tax = 0.17; }

        double total = price + (price * tax);
        Console.WriteLine($"The total price is {total}");
    }

    static void P2E7DisplaySineTable(double start, double step, int rows)
    {
        int counter = 0;
        Console.WriteLine($"{"x",3}  {"sin(x)",9}");
        while (counter < rows)
        {
            double sine = Math.Sin(start);
            Console.WriteLine($"{start,5:F4}  {sine,5:F4}");
            start += step;
            counter++;
        }
    }

    static int P3E1CalculateDifference(int first, int second)
    {
        int small, large;
        if (first > second)
        {
            small = second;
            large = first;
        }
        else
        {
            small = first;
            large = second;
        }

        int difference = large - small;
        return difference;
    }

    static string P3E4CalculateCommission(double saleAmount)
    {
        double commission = 0;
        if (saleAmount > 1000)
        {
            commission = saleAmount * 0.05;
        }
        return commission.ToString("F2");
    }

    static string P3E7HeronsFormula(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area.ToString("F2");
    }

    static void P4E1DoubleIt(ref int x)
    {
        x *= 2;
    }

    static void P4E4(int a, int b, out int sum, out int difference)
    {
        sum = a + b;
        difference = P3E1CalculateDifference(a, b);
    }

    static void P5E1DisplayIntArray(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write($"{number,3}");
        }
    }

    static int[] P5E2GenerateRandomIntArray(int numberOfItems, int largestValue)
    {
        int[] array = new int[numberOfItems];
        Random generator = new Random();
        for (int i = 0; i < numberOfItems; i++)
        {
            array[i] = generator.Next(largestValue);
        }
        return array;
    }

    static int[] P5E4CalculateDigitFrequencies(int[] array)
    {
        int[] frequencies = new int[10];
        foreach (int number in array)
        {
            frequencies[number]++;
        }
        return frequencies;
    }
}
