//1.Обчислення середнього заробітку:
//Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць.
//Після отримання всіх значень програма має обчислити та вивести середній заробіток.

Console.Write("How many workers? ");
int worker = int.Parse(Console.ReadLine());

int sum = 0; 

for (int i = 1; i <= worker; i++)
{
    Console.Write($"Enter salary of worker #{i}: ");
    int salary = int.Parse(Console.ReadLine());
    sum += salary;
}

double average = (double)sum / worker;
Console.WriteLine($"Avarage salary: {average} USD");



//2.Побудова графіку зірочками:
//Напишіть програму, яка будує графік за допомогою зірочок.
//Користувач повинен ввести кількість рядків графіка.
//Кожен рядок графіка має містити відповідну кількість зірочок.

//Console.Write("Input number of rows: ");

//int rows = int.Parse(Console.ReadLine());

//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}



//3.Генерація простих чисел:
//Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа.
//Просте число - це число, яке ділиться лише на 1 і на себе.

//Console.Write("Input the number up to which you want to generate prime numbers: ");

//int num = int.Parse(Console.ReadLine());

//Console.WriteLine($"Prime numbers from 1 to {num}:");

//for (int i = 2; i <= num; i++)
//{
//    bool isPrime = true;

//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.Write(i + " ");
//    }
//}



//4.Перевірка паролю:
//Напишіть програму, яка перевіряє пароль користувача.
//Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).

//Console.Write("Enter password: ");
//string password = Console.ReadLine();

//bool hasDigit = false;
//bool hasSpecial = false;
//string specialChars = "!@#$%^&*()-_=+[]{};:'\",.<>?/\\|`~";

//if (password.Length >= 8)
//{
//    for (int i = 0; i < password.Length; i++)
//    {
//        char ch = password[i];

//        if (ch >= '0' && ch <= '9')
//        {
//            hasDigit = true;
//        }

//        for (int j = 0; j < specialChars.Length; j++)
//        {
//            if (ch == specialChars[j])
//            {
//                hasSpecial = true;
//                break;
//            }
//        }
//    }

//    if (hasDigit && hasSpecial)
//    {
//        Console.WriteLine("Valid password");
//    }
//    else
//    {
//        Console.WriteLine("The password may consist of one number and one special character.");
//    }
//}
//else
//{
//    Console.WriteLine("The password can be at least 8 characters.");
//}



//5.Генерація фібоначчівської послідовності:
//Напишіть програму, яка генерує перші N чисел Фібоначчі.
//Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.

//Console.Write("Enter quantity N: ");
//int n = int.Parse(Console.ReadLine());

//int a = 0;
//int b = 1;

//for (int i = 0; i < n; i++)
//{
//    Console.Write(a + " ");

//    int next = a + b;
//    a = b;
//    b = next;
//}



//6.Калькулятор оплати праці за годину:
//Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки.
//Після введення значень програма має обчислити та вивести оплату за день.

//Console.Write("Enter the number of hours worked per day: ");
//int hours = int.Parse(Console.ReadLine());

//Console.Write("Enter rate per hour (USD): ");
//int rate = int.Parse(Console.ReadLine());

//int totalPay = 0;

//for (int i = 0; i < hours; i++)
//{
//    totalPay += rate;
//}

//Console.WriteLine("Payment per day:" + totalPay + " USD");



//7.Генерація таблиці множення для конкретного числа:
//Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.

//Console.Write("Enter a number for the multiplication table: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    int result = 0;

//    for (int j = 0; j < number; j++)
//    {
//        result += i;
//    }

//    Console.WriteLine($"{number} x {i} = {result}");
//}



//8.Перевірка на простоту:
//Напишіть програму, яка перевіряє, чи є задане користувачем число простим.
//Число вважається простим, якщо воно ділиться лише на 1 і на себе.

//Console.Write("Enter a number to check whether it is a prime number: ");
//int number = int.Parse(Console.ReadLine());

//bool isPrime = true;

//if (number <= 1)
//{
//    isPrime = false;
//}
//else
//{
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//}

//if (isPrime)
//{
//    Console.WriteLine($"{number} — prime!");
//}
//else
//{
//    Console.WriteLine($"{number} — is not prime!");
//}



