using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POEPART1
{
    internal class Recipe
    {
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;
        private int numIngredients;
        private int numSteps;
        private double scale;

        public Recipe() 
        {
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
            numIngredients = 0;
            numSteps = 0;
            scale = 1.0;
        }

        public void AddIngredients()
        {
            Console.WriteLine("Enter the number of ingredient:");
            numIngredients =int.Parse(Console.ReadLine());

            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Name" + (i + 1) + ":");
                ingredients[i] = Console.ReadLine();
                Console.WriteLine("Quantity" + (i + 1) + ":");
                quantities[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Unit of measurement" + (i + 1) + ":");
                units[i] = Console.ReadLine();
            }
        }

        public void AddSteps() 
        {
            Console.WriteLine("Enter the number of step:");
            numSteps = int.Parse(Console.ReadLine());

            steps = new string[numSteps];

            for (int i = 0;i < numSteps;i++) 
            {
                Console.WriteLine("Description" + (i + 1) + ":");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine();
            for (int i = 0; i < numIngredients; i++) 
            {
                Console.WriteLine(quantities[i] * scale + " " + units[i] + "" + ingredients[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < numSteps; i++) 
            {
                Console.WriteLine((i + 1) + "." + steps[i]);
            }
        }

        public void ScaleRecipe(double factor) 
        {
            scale = factor;
        }

        public void ResetQuantities() 
        {
            scale = 1.0;
        }

        public void ClearData()
        {
            ingredients = new string[0];

            quantities = new double[0];

            units = new string[0];

            steps = new string[0];

            numIngredients = 0;

            numSteps = 0;

            scale = 1.0;
        }

        
    }
}
