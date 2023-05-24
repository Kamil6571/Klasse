using System;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}

public class Customer : Person
{
    public string Email { get; set; }
    public string DiscountGroup { get; set; }
    public decimal TotalPurchase { get; set; }
}

public class Employee : Person
{
    public decimal Salary { get; set; }
    public decimal Commission { get; set; }

    public decimal CalculateCommission(decimal totalSalesPerDay)
    {
        return totalSalesPerDay * Commission;
    }

    public decimal CalculateTotalSalary(decimal totalSalesPerDay)
    {
        return Salary + CalculateCommission(totalSalesPerDay);
    }
}

public class Program
{
    public static void Main()
    {
        Person[] persons = new Person[5];

        persons[0] = new Customer
        {
            Name = "Abraham",
            LastName = "Lincoln",
            Address = "Abraham's Address",
            PhoneNumber = "123456789",
            Email = "abraham@example.com",
            DiscountGroup = "Group A",
            TotalPurchase = 5000
        };

        persons[1] = new Customer
        {
            Name = "Gilbert",
            LastName = "Skysovs",
            Address = "Gilbert's Address",
            PhoneNumber = "987654321",
            Email = "gilbert@example.com",
            DiscountGroup = "Group B",
            TotalPurchase = 10000
        };

        persons[2] = new Customer
        {
            Name = "Flomme",
            LastName = "Flommesen",
            Address = "Flomme's Address",
            PhoneNumber = "456789123",
            Email = "flomme@example.com",
            DiscountGroup = "Group C",
            TotalPurchase = 2000
        };

        persons[3] = new Customer
        {
            Name = "Blomme",
            LastName = "Blommesen",
            Address = "Blomme's Address",
            PhoneNumber = "789123456",
            Email = "blomme@example.com",
            DiscountGroup = "Group A",
            TotalPurchase = 8000
        };

        persons[4] = new Employee
        {
            Name = "Alexandre",
            LastName = "Alexandresen",
            Address = "Alexandre's Address",
            PhoneNumber = "321654987",
            Salary = 5000,
            Commission = 0.05m
        };

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═════════════════════════════╗");
        Console.WriteLine("║            Menu             ║");
        Console.WriteLine("╠═════════════════════════════╣");
        Console.WriteLine("║ 1. Opret en person           ║");
        Console.WriteLine("║ 2. Se alle personer         ║");
        Console.WriteLine("║ 3. Opret en kunde            ║");
        Console.WriteLine("║ 4. Opret en ansat            ║");
        Console.WriteLine("║ 5. Beregn provision          ║");
        Console.WriteLine("║ 6. Beregn total løn          ║");
        Console.WriteLine("║ 7. Luk programmet            ║");
        Console.WriteLine("╚═════════════════════════════╝");
        Console.ResetColor();

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.Write("Vælg en handling: ");
            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    UtworzOsobe(persons);
                    break;
                case "2":
                    WyswietlOsoby(persons);
                    break;
                case "3":
                    UtworzKunde(persons);
                    break;
                case "4":
                    UtworzPracownika(persons);
                    break;
                case "5":
                    BeregnProvision(persons);
                    break;
                case "6":
                    BeregnTotalLøn(persons);
                    break;
                case "7":
                    Console.WriteLine("Lukker programmet...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }
        }

        Console.WriteLine("╔════════════════════════════╗");
        Console.WriteLine("║ Tak fordi du bruger        ║");
        Console.WriteLine("║     fra vores program!     ║");
        Console.WriteLine("╚════════════════════════════╝");

        Console.WriteLine("Tryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }

    private static void UtworzOsobe(Person[] persons)
    {
        Console.Write("Navn: ");
        string navn = Console.ReadLine();

        Console.Write("Efternavn: ");
        string efternavn = Console.ReadLine();

        Console.Write("Adresse: ");
        string adresse = Console.ReadLine();

        Console.Write("Telefonnummer: ");
        string telefonnummer = Console.ReadLine();

        Person person = new Person
        {
            Name = navn,
            LastName = efternavn,
            Address = adresse,
            PhoneNumber = telefonnummer
        };

        for (int i = 0; i < persons.Length; i++)
        {
            if (persons[i] == null)
            {
                persons[i] = person;
                break;
            }
        }

        Console.WriteLine("Person oprettet!");
    }

    private static void WyswietlOsoby(Person[] persons)
    {
        Console.WriteLine("Alle personer:");
        foreach (var person in persons)
        {
            if (person != null)
            {
                Console.WriteLine($"Navn: {person.Name}");
                Console.WriteLine($"Efternavn: {person.LastName}");
                Console.WriteLine($"Adresse: {person.Address}");
                Console.WriteLine($"Telefonnummer: {person.PhoneNumber}");
                Console.WriteLine();
            }
        }

        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
        Console.ReadKey();
    }

    private static void UtworzKunde(Person[] persons)
    {
        Console.Write("Navn: ");
        string navn = Console.ReadLine();

        Console.Write("Efternavn: ");
        string efternavn = Console.ReadLine();

        Console.Write("Adresse: ");
        string adresse = Console.ReadLine();

        Console.Write("Telefonnummer: ");
        string telefonnummer = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Rabatgruppe: ");
        string rabatgruppe = Console.ReadLine();

        Console.Write("Totalindkøb: ");
        decimal totalindkøb = decimal.Parse(Console.ReadLine());

        Customer customer = new Customer
        {
            Name = navn,
            LastName = efternavn,
            Address = adresse,
            PhoneNumber = telefonnummer,
            Email = email,
            DiscountGroup = rabatgruppe,
            TotalPurchase = totalindkøb
        };

        for (int i = 0; i < persons.Length; i++)
        {
            if (persons[i] == null)
            {
                persons[i] = customer;
                break;
            }
        }

        Console.WriteLine("Kunde oprettet!");
    }

    private static void UtworzPracownika(Person[] persons)
    {
        Console.Write("Navn: ");
        string navn = Console.ReadLine();

        Console.Write("Efternavn: ");
        string efternavn = Console.ReadLine();

        Console.Write("Adresse: ");
        string adresse = Console.ReadLine();

        Console.Write("Telefonnummer: ");
        string telefonnummer = Console.ReadLine();

        Console.Write("Løn: ");
        decimal løn = decimal.Parse(Console.ReadLine());

        Console.Write("Provision: ");
        decimal provision = decimal.Parse(Console.ReadLine());

        Employee employee = new Employee
        {
            Name = navn,
            LastName = efternavn,
            Address = adresse,
            PhoneNumber = telefonnummer,
            Salary = løn,
            Commission = provision
        };

        for (int i = 0; i < persons.Length; i++)
        {
            if (persons[i] == null)
            {
                persons[i] = employee;
                break;
            }
        }

        Console.WriteLine("Ansat oprettet!");
    }

    private static void BeregnProvision(Person[] persons)
    {
        Console.Write("Totaltsalg pr. dag: ");
        decimal totaltsalgPrDag = decimal.Parse(Console.ReadLine());

        foreach (var person in persons)
        {
            if (person is Employee employee)
            {
                decimal provision = employee.CalculateCommission(totaltsalgPrDag);
                Console.WriteLine($"Provision for {employee.Name} {employee.LastName}: {provision}");
            }
        }

        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
        Console.ReadKey();
    }

    private static void BeregnTotalLøn(Person[] persons)
    {
        Console.Write("Totaltsalg pr. dag: ");
        decimal totaltsalgPrDag = decimal.Parse(Console.ReadLine());

        foreach (var person in persons)
        {
            if (person is Employee employee)
            {
                decimal totalLøn = employee.CalculateTotalSalary(totaltsalgPrDag);
                Console.WriteLine($"Total løn for {employee.Name} {employee.LastName}: {totalLøn}");
            }
        }

        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
        Console.ReadKey();
    }
}
