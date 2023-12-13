// Alias any type
//using P = NewCSharpFeatures.Person;

namespace NewCSharpFeatures;


public class _3OtherFeatures
{

	public static void Run()
	{

		var person = new Person("Jeff", "Fritz");
		BusinessLogic.DoStuff(ref person);

	}

}


public class BusinessLogic
{

	public static void DoStuff(ref readonly Person person)
	{

		// Cannot change the value of a readonly ref parameter
		//person = new Person("Mads", "Torgersen");
		//person.BirthDate = new DateTime(1976, 8, 1);


	}
	

}

