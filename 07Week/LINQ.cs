using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
	public static void Main()
	{
        List<Person> people = new List<Person>()
        {
            new Person() { FirstName = "Maxfield", LastName = "Gaj", Birthdate = DateTime.Now.AddYears(-24)},
            new Person() { FirstName = "Jules", LastName = "Winnfield", Birthdate = Convert.ToDateTime("07/13/1964")},
            new Person() { FirstName = "Vincent", LastName = "Vega", Birthdate = Convert.ToDateTime("01/01/1967")},
            new Person() { FirstName = "Marcellus", LastName = "Wallace", Birthdate = Convert.ToDateTime("06/22/1970")},
            new Person() { FirstName = "Mia", LastName = "Wallace", Birthdate = Convert.ToDateTime("06/12/1990")}
        };

        //List<Person> peopleWithM = new List<Person>();

        //foreach (var p in people)
        //{
        //  if (p.FirstName[0] == 'M')
        //    {
        //        peopleWithM.Add(p);
        //    }
        //}

        // LINQ Queries
        var peopleYounger30 = from p in people
                              where DateTime.Today.Year - p.Birthdate.Year < 30
                              orderby p.LastName descending
                              select $"{p.FirstName} {p.LastName}";
        // LINQ Methods
        var peopleOlder30 = people
            .Where(p => DateTime.Today.Year - p.Birthdate.Year > 30)
            .OrderByDescending(p => p.LastName)
            .Select(p => $"{p.FirstName} {p.LastName}"); 

        // Console.WriteLine(string.Join(", ", peopleWithM));
        foreach (var p in peopleOlder30)
        {
            Console.WriteLine(p);
        }

        Console.ReadLine();
    }
}

public class Person
{
    //Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }

}

