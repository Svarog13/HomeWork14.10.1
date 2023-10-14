using System;

while (true)
{
    Console.WriteLine("Enter two digits: ");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("Choose the operation: 1 - Addition, 2 - Subtraction, 3 - Multiplication, 4 - Division, 0 - Exit:  ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            double addition = a + b;
            Console.WriteLine($"{a} + {b} = {addition} ");
            break;
        case 2:
            double subtraction = a - b;
            Console.WriteLine($"{a} - {b} = {subtraction} ");
            break;
        case 3:
            double multiplication = a * b;
            Console.WriteLine($"{a} * {b} = {multiplication} ");
            break;
        case 4:
            if (b != 0)
            {
                double division = (double)a / b;
                Console.WriteLine($"{a} / {b} = {division} ");
            }
            else
            {
                Console.WriteLine("Error: Division by zero!");
            }
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Error: Invalid choice!");
            break;
    }
}
