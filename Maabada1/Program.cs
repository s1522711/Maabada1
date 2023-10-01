namespace Maabada1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a+ b;
            a = 5;
            b = 7;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("a+b=" + (a + b));
            */

            /*
            int a = 10;
            int b = 100;
            Console.WriteLine("A=" + a + ", B=" + b + ", A+B=" + (a + b) + ", A*B=" + (a * b));
            */

            /*
            int num;
            num = 83;
            num = 90;
            Console.WriteLine("num is" + num);
            */

            /*
            Console.Write("Give me the side of a square: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("S=" + (side * 4) + ", P=" + (side * side));
            */

            /*
            Console.Write("Give me the amount of boys in the class: ");
            int boys = int.Parse(Console.ReadLine());
            Console.Write("Give me the amount of girls in the class: ");
            int girls = int.Parse(Console.ReadLine());
            Console.WriteLine("The total amount of students in the class is: " + (boys + girls));
            Console.WriteLine("You need " + (42 - (boys + girls)) + " more students to have a valid class");
            */

            /*
            int numInt = 15;
            double numDouble;
            numDouble = numInt;
            Console.WriteLine("numInt=" + numInt);
            Console.WriteLine("numDouble=" + numDouble);
            */

            /*
            int numInt;
            double numDouble;
            numDouble = 9.6;
            numInt = (int)numDouble;
            Console.WriteLine("numInt=" + numInt);
            Console.WriteLine("numDouble=" + numDouble);
            */

            /*
            Console.Write("Give me a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give me another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The second number: " + num2);
            Console.WriteLine("The first number: " + num1);
            */

            /*
            Console.Write("Give me the first side of the rectangle: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Give me the second side of the rectangle: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("P=" + (side1*side2) + ", S=" + ((side1+side2)*2));
            */

            /*
            Console.Write("give me the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("give me the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("give me the third number: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.Write("give me the fourth number: ");
            double num4 = double.Parse(Console.ReadLine());
            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average is: " +  average);
            */

            /*
            Console.Write("Give me the price of your flight to japan in USD: ");
            double flightCost = double.Parse(Console.ReadLine());
            Console.Write("Give me the the amount of ILS that one USD is worth right now: ");
            double usdValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Your flight costs " +  (flightCost*usdValue) + " in ILS");
            */

            /*
            int a, b, temp;
            Console.Write("enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter second number: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            */

            /*
            Console.Write("give me the first number: ");
            string num1 = Console.ReadLine();
            Console.Write("give me the second number: ");
            string num2 = Console.ReadLine();
            Console.Write("give me the third number: ");
            string num3 = Console.ReadLine();
            Console.WriteLine(num1);
            Console.WriteLine(" " + num2);
            Console.WriteLine("  " + num3);
            Console.WriteLine("   " + num1 + " " + num2);
            Console.WriteLine("    " + num1 + num2 + num3);
            */

            /*
            Console.Write("Give me the first number in the series: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Give me the distance between 2 numbers in the series: ");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("The third number in the series: " + (startNum + distance*2).ToString());
            Console.WriteLine("The fourth number in the series: " + (startNum + distance * 3).ToString());
            */
            
            /*
            Console.Write("Give me the first number in the series: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Give me the distance between 2 numbers in the series: ");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("The third number in the series: " + (startNum + distance * 2).ToString());
            Console.WriteLine("The fourth number in the series: " + (startNum + distance * 3).ToString());
            Console.WriteLine("The sum of the first 4 numbers in the series: " + (startNum + (startNum + distance) + (startNum + distance*2) + (startNum + distance*3)));
            */
            
            /*
            Console.Write("Give me a 3 digit number: ");
            int num = int.Parse(Console.ReadLine());
            int n1, n2, n3;
            n1 = num % 10;
            num = num / 10;
            n2 = num % 10;
            n3 = num / 10;
            Console.WriteLine("The reversed number is: " + (n1*100 + n2*10 + n3));
            */
            
            /*
            Console.Write("Give me the price of the product: ");
            int input = int.Parse(Console.ReadLine());
            int tenIlsCoins, left, fiveIlsCoins;
            tenIlsCoins = input / 10;
            left = input - tenIlsCoins*10;
            fiveIlsCoins = left / 5;
            left = left - fiveIlsCoins*5;
            Console.WriteLine("You will need " + tenIlsCoins + " coins of 10ILS, you will need " + fiveIlsCoins + " coins of 5ILS and you will need " + left + " of 1ILS coins");
            */
            
            /*
            Console.Write("Give me the day of the week: ");
            string dayOfWeekInput = Console.ReadLine().ToLower();
            Console.Write("How many days are left till ur bday? ");
            int daysToBdayLeft = int.Parse(Console.ReadLine());
            int dayOfWeek = 0;
            if (dayOfWeekInput == "saturday")
            {
                dayOfWeek = 0;
            }
            else if (dayOfWeekInput == "sunday")
            {
                dayOfWeek = 1;
            }
            else if (dayOfWeekInput == "monday")
            {
                dayOfWeek = 2;
            }
            else if (dayOfWeekInput == "tuesday")
            {
                dayOfWeek = 3;
            }
            else if (dayOfWeekInput == "wednesday")
            {
                dayOfWeek = 4;
            }
            else if (dayOfWeekInput == "thursday")
            {
                dayOfWeek = 5;
            }
            else if (dayOfWeekInput == "friday")
            {
                dayOfWeek = 6;
            }
            int resultDayOfWeek = daysToBdayLeft + dayOfWeek;
            while (resultDayOfWeek > 6)
            {
                resultDayOfWeek = resultDayOfWeek - 7;
            }

            string outputDayOfWeek = "saturday";
            if (resultDayOfWeek == 0)
            {
                outputDayOfWeek = "saturday";
            }
            else if (resultDayOfWeek == 1)
            {
                outputDayOfWeek = "sunday";
            }
            else if (resultDayOfWeek == 2)
            {
                outputDayOfWeek = "monday";
            }else if (resultDayOfWeek == 3)
            {
                outputDayOfWeek = "tuesday";
            }else if (resultDayOfWeek == 4)
            {
                outputDayOfWeek = "wednesday";
            }else if (resultDayOfWeek == 5)
            {
                outputDayOfWeek = "thursday";
            }else if (resultDayOfWeek == 6)
            {
                outputDayOfWeek = "friday";
            }
            Console.WriteLine("Your birthday will fall on " + outputDayOfWeek);
            */
            
            /*
            const double PI=3.14;
            double radius , area;
            Console.WriteLine ("enter radius");
            radius=double.Parse(Console.ReadLine());
            area = PI*radius*radius;
            Console.WriteLine ("area ="+ area);
            */
        }
    }
}