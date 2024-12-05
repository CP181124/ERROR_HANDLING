using System;

namespace ErrorHandling
{
    internal class Program
    {
        /// <summary>
        /// CLI for the 3 calculation programs in the ERROR HANDLING exercise
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                System.Console.WriteLine(@$"
---------------------------------------------------
Select which program to run:
    1: Multiply a number by 10
    2: Calculate the area and perimiter of a circle
    3: Calculate the volume of a sphere
    quit: Exit program
---------------------------------------------------
Please enter a valid input:");
                // Input string
                string userInputText = Console.ReadLine();
                // Check if user wants to stop the program
                if (userInputText.ToLower().Equals("quit"))
                {
                    // end program by reversing the while condition
                    System.Console.WriteLine("Shutting down.");
                    run = false;
                }
                //Check for valid integer for program choice
                else if (int.TryParse(userInputText, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MultiplyConsole();
                            break;
                        case 2:
                            CircleAPconsole();
                            break;
                        case 3:
                            SphereConsole();
                            break;
                    }
                } // else invalid input, rerun the loop.
                else
                {
                    System.Console.WriteLine(@$"
  Invalid input, please input a valid value (1, 2, 3 or quit)");
                }
            }
        }
        /// <summary>
        /// Takes an integer number to be multiplied by 10.
        /// </summary>
        /// <param name="number">Integer to be multiplied.</param>
        /// <returns>The number multiplied by 10.</returns>
        static int MultiplyIntBy10(int number)
        {
            return number * 10;
        }
        /// <summary>
        /// Takes a radius double and returns a tuple with calculated area
        /// and perimiter values
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        /// 
        static (double area, double perimiter) CircleAP(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;

            return (area, perimeter);
        }
        /// <summary>
        /// Takes and verifies a radius input and presents the
        /// values calculated by CircleAP using the radius.
        /// </summary>
        static void CircleAPconsole()
        {
            double area;
            double perimiter;
            bool run = true;

            while (run)
            {
                System.Console.WriteLine(@$"
----------------------------------------
Circle area and perimiter calculator:
To go back to the menu, type 'x'
----------------------------------------
Please input the radius of your circle:");
                string userInputText = Console.ReadLine();
                if (userInputText.ToLower().Equals("x"))
                {
                    //end program by reversing the while condition
                    run = false;
                }
                else if (double.TryParse(userInputText, out double radius))
                {// check if input can resolve as a double
                    (area, perimiter) = CircleAP(radius);
                    //Print the output and format numbers using the built in ToString method
                    System.Console.WriteLine(@$"
                    Circle radius: {radius.ToString("F")}
                    Circle area: {area.ToString("F")}
                    Circle perimiter: {perimiter.ToString("F")}
                    ");
                } // else rerun the program loop.
                else
                {
                    System.Console.WriteLine(@$"
  !Invalid input, please input a valid floating point number
  or type 'x' to exit!");
                }
            }
        }

        /// <summary>
        /// Takes and verifies a integer input and presents the
        /// number calculated by MutliplyIntBy10.
        /// </summary>
        static void MultiplyConsole()
        {
            bool run = true;

            while (run)
            {
                System.Console.WriteLine(@$"
----------------------------------------
Multiply your integer by 10:
To go back to the menu, type 'x'
----------------------------------------
Please input the integer number to be multiplied by 10:");
                string userInputText = Console.ReadLine();
                if (userInputText.ToLower().Equals("x"))
                {
                    //end program by reversing the while condition
                    run = false;
                }
                else if (int.TryParse(userInputText, out int inputNumber))
                {   // check if input can resolve as an integer
                    int result = MultiplyIntBy10(inputNumber);
                    //print output
                    System.Console.WriteLine(@$"
                    10 x {inputNumber} = {result}
                    ");

                } // else rerun the program loop.
                else
                {
                    System.Console.WriteLine(@$"
  !Invalid input, please input a valid integer
  or type 'x' to exit!");
                }
            }
        }

        /// <summary>
        /// Takes a radius argument to calculate the volume of a sphere
        /// </summary>
        /// <param name="radius">Radius of a sphere</param>
        /// <returns>The <em>volume</em> of a sphere in the form of a double</returns>
        static double SphereCalc(double radius)
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Takes and verifies a radius input and presents the
        /// volume calculated by SphereCalc using the radius.
        /// </summary>
        static void SphereConsole()
        {
            bool run = true;

            while (run)
            {
                System.Console.WriteLine(@$"
----------------------------------------
Calculate the area of a sphere:
To go back to the menu, type 'x'
----------------------------------------
Please input the radius of your sphere:");
                string userInputText = Console.ReadLine();
                if (userInputText.ToLower().Equals("x"))
                {
                    //end program by reversing the while condition
                    run = false;
                }
                else if (double.TryParse(userInputText, out double radius))
                {// check if input can resolve as an integer
                    double result = SphereCalc(radius);
                    //print output and format using the colon shorthand
                    System.Console.WriteLine(@$"
                    Sphere radius: {radius:F2}
                    Sphere volume: {result:F2}
                    ");

                } // else rerun the program loop.
                else
                {
                    System.Console.WriteLine(@$"
  !Invalid input, please input a valid floating point number
  or type 'x' to exit!");
                }
            }
        }
    }
}
