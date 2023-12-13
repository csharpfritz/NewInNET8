namespace NewCSharpFeatures;

// The presence of a primary constructor
// // removes the implicit parameterless constructor

public class Person(string FirstName, string LastName)
{

	// Additional constuctors must route through the primary constructor

	public Person(string FirstName, string LastName, DateTime BirthDate) : this(FirstName, LastName)
	{
		this.BirthDate = BirthDate;
	}

	public string GivenName {
		get { return FirstName; }
		set { FirstName = value; }
	}


	public override string ToString()
	{
		return $"{FirstName} {LastName}";
	}

	// Add an Age property
	public int Age => BirthDate.HasValue ? (int)DateTime.Now.Subtract(BirthDate.Value).TotalDays / 365 : throw new ArgumentException("Birthdate is not assigned");

	public DateTime? BirthDate { get; set; }
}

public class _1PrimaryConstructors
{

	public static void Run()
	{

		// Let's create some people
		var people = new Person[] {
			new Person("Jeff", "Fritz", new DateTime(1976, 8, 1)),
			new Person("Momma", "Fritz")
		};

		// Let's print out their ages
		foreach (var person in people)
		{
			Console.WriteLine($"{person} is {person.Age} years old");
		}

		// We cannot access the properties injected by the primary constructor
		//var firstName = people[0].FirstName;

	}

}

public class TechSpeaker(string FirstName, string LastName) : Person(FirstName, LastName)
{

}

