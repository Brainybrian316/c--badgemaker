// using System;
// using System.Collections.Generic;
// using System.Collections.Generic;

// namespace CatWorx.BadgeMaker
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {

//       //* practice
//       //!approach 1
//       // float side = 3.14F;
//       // float area = side * side;
//       // Console.WriteLine("area: {0}", area);

//       //! approach 2
//       // double side = 3.14;
//       // double area = side * side;

//       //* arithmetic methods
//       // Console.WriteLine("area is a {0}", area.GetType()); getting the type
//       // Console.WriteLine("area: {0}", area);
//       //  Console.WriteLine(2 * 3);  // basic arithmetic + - * /
//       //  Console.WriteLine( 10 % 3); // modulus operator checks for remainder
//       //  Console.WriteLine(1 + 2 * 3); // order of operations
//       //  Console.WriteLine( 10 / 3.0); // integer and double division
//       //  Console.WriteLine( 10 / 3);  // integer
//       //  Console.WriteLine("12" + "3"); // string concatenation
//       //! increment and decrement
//       //  int num = 10; 
//       //  num += 100; //! this is the same as num = num + 100
//       //  Console.WriteLine(num); 
//       //  num ++; //! this is how you increment
//       //  Console.WriteLine(num);

//       //! booleans
//       // bool isCold = true;
//       // Console.WriteLine(isCold ? "drink" : "add ice"); //! ternary operator is true
//       // Console.WriteLine(!isCold ? "drink" : "add ice"); //! ternary operator is false

//       // *Data Type conversions
//       // string stringNum = "2"; //! string
//       // @ ToInt32 is a method that converts a string to an integer
//       // int intNum = Convert.ToInt32(stringNum); //! convert string to int
//       // Console.WriteLine(intNum);
//       // Console.WriteLine(intNum.GetType());

//       //! Data Structures

//       //* dictionaries
//       //@ approach 1
//       // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
//       // myScoreBoard.Add("firstInning", 10);
//       // myScoreBoard.Add("secondInning", 20);
//       // myScoreBoard.Add("thirdInning", 30);
//       // myScoreBoard.Add("fourthInning", 40);
//       // @ approach 2
//       // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>()
//       // {
//       //   {"firstInning", 10},
//       //   {"secondInning", 20},
//       //   {"thirdInning", 30},
//       //   {"fourthInning", 40}
//       // };

//       // // populating a dictionary in the console long way
//       // Console.WriteLine("---------------");
//       // Console.WriteLine("Scoreboard");
//       // Console.WriteLine("---------------");
//       // Console.WriteLine("Inning  |  Score");
//       // Console.WriteLine(" 1      |    {0}", myScoreBoard["firstInning"]);
//       // Console.WriteLine(" 2      |    {0}", myScoreBoard["secondInning"]);
//       // Console.WriteLine(" 3      |    {0}", myScoreBoard["thirdInning"]);
//       // Console.WriteLine(" 4      |    {0}", myScoreBoard["fourthInning"]);

//       // * arrays
//       // string[] favFoods = new string[3] { "pizza", "doughnuts", "ice cream" };
//       // string firstFood = favFoods[0];
//       // string secondFood = favFoods[1];
//       // string thirdFood = favFoods[2];
//       // Console.WriteLine(" I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

//       // * lists
//       List<string> employees = new List<string>() { "adam", "amy" };
//       employees.Add("jim");
//       employees.Add("billy");
//       Console.WriteLine("My employees are {0}, {1}, {2}, and {3}", employees[0], employees[1], employees[2], employees[3]);
//       //* loops
//       // @ looping through employees list
//       for (int i = 0; i < employees.Count; i++)
//       {
//         Console.WriteLine(employees[i]);
//       }
//     }
//   }
// }