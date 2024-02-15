using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ConsoleTask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();

            static void Task1()
            {
                



                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());



                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }
            static void Task2()
            {
            
            l1:
                Console.WriteLine("Enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = int.Parse(Console.ReadLine());

                if (a % b == 0)
                {

                    int c = a / b;
                    Console.WriteLine(c);
                }

                else
                {
                    Console.WriteLine("Enter the number again.");
                    goto l1;
                }



            }
            static void Task3()
            {
               
                Console.WriteLine("Enter a number");
            l2:
                int number = int.Parse(Console.ReadLine());

                if (number % 10 == 7)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("No");
                    goto l2;
                }
            }
            static void Task4()
            {
           
            l3:
                Console.WriteLine("Enter to digit number");
                int number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 99)
                {
                    int digit1 = number / 10;
                    int digit2 = number % 10;

                    if (digit1 == digit2)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }


                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a 2-digit number");
                    goto l3;
                }
            }
            static void Task5()
            {
                Console.WriteLine("Enter a two-digit number: ");
                int number = int.Parse(Console.ReadLine());


                if (number >= 10 && number <= 99)
                {

                    int originalNumber = number;
                    int sumOfDigits = 0;
                    int productOfDigits = 1;


                    while (number > 0)
                    {
                        int digit = number % 10;
                        sumOfDigits += digit;
                        productOfDigits *= digit;
                        number /= 10;
                    }


                    if (sumOfDigits % 2 == 0)
                    {
                        Console.WriteLine($"Product : {productOfDigits}");
                    }
                    else
                    {
                        Console.WriteLine("There is only one digit in the number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a two-digit number.");
                }

            }
            static void Task6()
            {
                Student s1 = new Student();
                s1.name = "Yaqub";
                s1.surname = "Ehmedov";
                s1.id = 1;
                s1.birthDate = new DateTime(2004, 07, 22);


            }
            static void Task7()
            {
                string[] dateStrings = { "14.03.2023", "18.09.2009", "18.02.2002", "18.12.2006" };

                CultureInfo azerbaijaniCulture = new CultureInfo("az-Latn-AZ");

                foreach (var dateString in dateStrings)
                {
                    DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    string formattedDate = date.ToString("MMMM dd, yyyy", azerbaijaniCulture);

                    Console.WriteLine($"{dateString}-{formattedDate}");
                }
            }














        }



    }


}


