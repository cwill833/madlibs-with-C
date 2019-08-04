using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a test of C# with mad libs and using reading and writing to the console
      Author: Chris Williams
      */

			// prints title and welcome message
			Console.WriteLine("Get ready for madlibs!");
    	string title = "Chris' mad libs";
			Console.WriteLine(title);

			// gets a characters name
			Console.Write("Enter a name: ");
			string name = Console.ReadLine();

			// get adjs
			Console.WriteLine("Please give me an adjective, anything you want: ");
			string adj1 = Console.ReadLine();
			Console.WriteLine("One more: ");
			string adj2 = Console.ReadLine();
			Console.WriteLine("Promis this is the last one: ");
			string adj3 = Console.ReadLine();

			// get verb
			Console.WriteLine("Now how bout a verb: ");
			string verb = Console.ReadLine();

			// get nouns
			Console.WriteLine("You have been doing great! Few more inputs then we are done. Lets do a noun: ");
			string noun1 = Console.ReadLine();
			Console.WriteLine("Last noun: ");
			string noun2 = Console.ReadLine();

			Console.WriteLine("Now lets make the story interesting. I'm going to ask you a couple of inputs so we can really get rocking.");

			Console.WriteLine("Animal: ");
			string animal = Console.ReadLine();
			Console.WriteLine("Food: ");
			string food = Console.ReadLine();
			Console.WriteLine("Fruit: ");
			string fruit = Console.ReadLine();
			Console.WriteLine("Superhero: ");
			string superhero = Console.ReadLine();
			Console.WriteLine("Country: ");
			string country = Console.ReadLine();
			Console.WriteLine("Dessert: ");
			string dessert = Console.ReadLine();
			Console.WriteLine("year: ");
			string year = Console.ReadLine();

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

      Console.WriteLine(story);

    }
  }
}
