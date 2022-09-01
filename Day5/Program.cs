using Day5;

Person yuli = new Customer("Yuli", "Einstain", "albert@gmail.com", new DateTime(1833, 9, 12), "1001");
Customer widi = new Customer("Widi", "Einstain", "widi@gmail.com", new DateTime(1833, 9, 12), "1002");
Customer rini = new Customer("Rini", "Einstain", "rini@gmail.com", new DateTime(1833, 9, 12), "1003");

var listOfCustomer = new List<Person> { yuli, widi, rini };

var incomeYuli = new Dictionary<string, decimal>
{
    {"Kontrakan",10_000_000 },
    {"Jual Kontrakan",10_000_000}
};
yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal>
{
    {"Rental",20_000_000 },
    {"Toko",5_000_000}
};
widi.TotalRevenue = widi.TotalIncome(incomeYuli);

var incomeRini = new Dictionary<string, decimal>
{
    {"Super Market",15_000_000 },
    {"Jual Kontrakan",15_000_000}
};
rini.TotalRevenue = rini.TotalIncome(incomeRini);

foreach (var item in listOfCustomer)
{
    Console.WriteLine(item);
    Console.WriteLine();
}


Console.WriteLine("-------------------Revenue Highest------------------------");
var listHigest = listOfCustomer.Where(c => c.TotalRevenue >= 50_000_000);
foreach (var item in listHigest)
{
    Console.WriteLine(item.ToString());
}
var listMin = listOfCustomer.Min(x => x.TotalRevenue);
Console.WriteLine("Min Revenue = " + listMin);

var listMax = listOfCustomer.Max(x => x.TotalRevenue);
Console.WriteLine("Max Revenue = " + listMax);


var listLessThanMax = listOfCustomer.Where(x => x.TotalRevenue < listMin);
Console.WriteLine("-----------------Revenue Lower Than Max-------------------");
foreach (var item in listLessThanMax)
{
    Console.WriteLine(item.ToString);
}


Console.WriteLine("---------------------Select---------------");
var query = listOfCustomer.Select(cust => new
{
    FullName = cust.FirstName + " " + cust.LastName,
    Email = cust.Email,
    TotalRevenue = cust.TotalRevenue
}
);

foreach (var item in query)
{
    Console.WriteLine(item);
}

Console.ReadLine();

//Console.WriteLine("---------------------LINQ------------------------------");
//LinQ.IntroLinq();