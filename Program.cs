using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POEPART1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            while (true) 
            {
                Console.WriteLine("1. Enter ingredients");
                Console.WriteLine("2. Enter steps");
                Console.WriteLine("3. Display recipe");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset quantities");
                Console.WriteLine("6. Clear recipe");
                Console.WriteLine("7. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice) 
                {
                    case 1:
                        recipe.AddIngredients();
                        break;

                    case 2:
                        recipe.AddSteps();
                        break;

                    case 3:
                        recipe.DisplayRecipe();
                        break;

                    case 4:
                        Console.WriteLine("Enter the scaling factor (0.5, 2, or 3): ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        break;

                    case 5:
                        recipe.ResetQuantities();
                        break;

                    case 6:
                        recipe.ClearData();
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Invalid choice. Please try again.");

                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
