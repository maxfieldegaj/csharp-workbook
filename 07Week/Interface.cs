using System;

public class Program
{
	public static void Main()
	{
        House myHouse;
        ContractorA contractorA = new ContractorA();
        ContractorB contractorB = new ContractorB();

        if(contractorA.Estimate() < contractorB.Estimate())
        {
            myHouse = new House(contractorA);
        } 
        else
        {
            myHouse = new House(contractorB);
        }

        myHouse.StartRenovation();

        Console.WriteLine($"The contractor that is goiong to renovate my house is {myHouse.whoGotHired()}");
        Console.WriteLine($"This contractor charged me {myHouse.howMuchContractorCharged()}");

        Console.WriteLine($"The kitchen will be done on {myHouse.Kitchen}");
        Console.WriteLine($"The bedroom will be done on {myHouse.Bedroom}");
        Console.WriteLine($"The bathroom will be done on {myHouse.Bathroom}");
        Console.ReadLine();
	}
}

// Contract
public interface IRenovationContract
{
    DateTime RenovateKitchen(string color);
    DateTime RenovateBedroom(string color);
    DateTime RenovateBathroom(string color);

    int Estimate();
}

public interface IKitchenRenovation
{
    // Specific on kitchen
}

public interface IBathroomnRenovation
{
    // Specifics on bathroom
}

// Contractor A
public class ContractorA : IRenovationContract
{
    public int Estimate()
    {
        Random r = new Random();
        return r.Next(8000, 12000);
    }

    public DateTime RenovateBathroom(string color)
    {
        // TODO - Working on  renovating the bathroom
        return DateTime.Now.AddDays(5);

    }

    public DateTime RenovateBedroom(string color)
    {
        return DateTime.Now.AddDays(6);
    }

    public DateTime RenovateKitchen(string color)
    {
        return DateTime.Now.AddDays(9);
    }
}

public class ContractorB : IRenovationContract
{
    public int Estimate()
    {
        return 10000;
    }

    public DateTime RenovateBathroom(string color)
    {
        // TODO - Working on  renovating the bathroom
        return DateTime.Now.AddDays(4);

    }

    public DateTime RenovateBedroom(string color)
    {
        return DateTime.Now.AddDays(3);
    }

    public DateTime RenovateKitchen(string color)
    {
        return DateTime.Now.AddDays(7);
    }
}

// House 
public class House
{
    // Dependency
    private IRenovationContract _contract;

    public DateTime Kitchen { get; set; }
    public DateTime Bathroom { get; set; }
    public DateTime Bedroom { get; set; }

    // Constructor
    public House(IRenovationContract contract) // Inject Dependency
    {
        _contract = contract;
    }

    public void StartRenovation()
    {
        Bedroom = _contract.RenovateBedroom("grey");
        Bathroom = _contract.RenovateBathroom("white");
        Kitchen = _contract.RenovateKitchen("cyan");
    }

    public string whoGotHired()
    {
        return _contract.ToString();
    }

    public int howMuchContractorCharged()
    {
        return _contract.Estimate();
    }

}