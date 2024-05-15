using System.Diagnostics.Metrics;

namespace LearnCSharpObj
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* PERSON 1
			 
			// Got to create a file called Person.cs
			// to contain the class Person, and then create the
			// Program.cs file to instanciate object of Person class.

			// Ways to instanciate objects:
			Person person1 = new Person();
			//Person person3 = new();

			var person1FirstName = Console.ReadLine();
			var person1LastName = Console.ReadLine();
			var person1Age = Convert.ToByte(Console.ReadLine());
			var gender = Console.ReadLine();

			if (person1FirstName != null && 
				person1LastName != null &&
				gender != null)
			{
				var person1Gender = Convert.ToChar(gender);
				// Access classes fields with the '.' operator:
				person1.SetFirstName(person1FirstName)
					   .SetLastName(person1LastName)
					   .SetAge(person1Age)
					   .SetGender(person1Gender);
			}
			

			Console.WriteLine(person1.GetFullName());
			Console.WriteLine(person1.SayHi());
			Console.WriteLine(person1.SayAge());
			Console.WriteLine(person1.SayGender());
			
            var person2 = new Person("John", "Doe", 25);
			string greeting = person2.SetFirstName("Jane")
									 .SetLastName("Doe")
									 .SayHi();

			Console.WriteLine(greeting);
			

			var person3 = new Person("Luca", "Veronelli", 21);
			*/

			/* PERSON 2

			var p1 = new Person();
			p1.FirstName = "John";
			p1.LastName = "Doe";
			p1.Age = 23;

			Console.WriteLine(p1.FullName);
             */

			/* SKILL
			
            var s1 = new Skill();
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Rating);
			*/

            /* CONVERTER
			
            var c1 = new Converter();
            Console.WriteLine(c1.KgToPound(12m));
            Console.WriteLine(c1.PoundToKg(26.460m));

            decimal weightInKg, weightInLbs;
			var converter = new Converter();

			Console.WriteLine($"Convert weight from kg to lbs (factorr = {Converter.Factor})");

			while (true)
			{
				// Prompt to enter a weight in Kg
				Console.Write("Enter a wight in kg (0 to exit): ");
				weightInKg = Convert.ToDecimal(Console.ReadLine());

				if (weightInKg == 0)
				{
					break;
				}

				// Convert from Kg to Lbs.
				weightInLbs = converter.KgToPound(weightInKg);
				Console.WriteLine($"{weightInKg} kg = {weightInLbs} Lbs");
			}

			*/

            /* PERSON 3
            
			var p1 = new Person();
			p1.FirstName = "John";
			p1.LastName = "Doe";
			p1.Age = 25;

			var p2 = new Person("Jane", "Doe");
			p2.Age = 22;

			// Object initializer allows you to avoid using
			// constructors to initialize objects:
			var p3 = new Person()
			{
				FirstName = "Luca",
				LastName = "Veronelli",
				Age = 21
			};
			
			*/

            /* SENTENCE
             
			var sentence = new Sentence("C# is awesome.");

			Console.WriteLine(sentence[0]);
			Console.WriteLine(sentence[1]);
			Console.WriteLine(sentence[2]);
			
            */

            /* MATRIX
			
			var matrix = new Matrix(3, 3)
			{
				[0, 0] = 1,
				[0, 1] = 2,
				[0, 2] = 3,
				[1, 0] = 4,
				[1, 1] = 5,
				[1, 2] = 6,
				[2, 0] = 7,
				[2, 1] = 8,
				[2, 2] = 9
			};

			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					Console.Write($"{matrix[row, col]} ");
				}
				Console.WriteLine();
			}

			*/

            /* PERSON 4
			 
			var person = new Person()
			{
				Name = "John",
				Age = 22
			};

			*/

            /* LENGTHCONVERTER
			 double feet, meters;

			// Feet to meters:
			feet = 100;
            // You can avoid to put the 'ClassName.' before the method by
            // putting the 'global using static LearnCSharpObj.LengthConverter'
			// directive.
            meters = /*LengthConverter.
            FeetToMeters(feet);

            Console.WriteLine($"{feet} ft = {meters:0.##} m.");

            // Meters to feet:
            meters = 10;
            feet = MetersToFeet(meters);

            Console.WriteLine($"{meters} m = {feet:0.##} ft.");
            */

			
        }
    }
}
