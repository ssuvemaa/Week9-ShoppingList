using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {


            //Näiteks soovid: apple, orange, watermelon, strawberry, blueberry
            string fileLocation = @"C:\Users\...\samples\ShoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a product to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter product:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }


            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your product: {wish}");
            }


            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
    }
}