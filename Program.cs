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
			Console.WriteLine("Get ready for madlibs!");
    	string title = "Chris' mad libs";

    	Console.WriteLine(title);

			Console.Write("Enter a name: ");
			string name = Console.ReadLine();

      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";

      Console.WriteLine(story);

    }
  }
}
