using System;
using System.Collections.Generic;

internal class City
{
    private string name;
    private string country;
    private int population;
    private string phoneCode;
    private string districts;
    public void InputData()
    {
        Console.Write("Enter city name: ");
        name = Console.ReadLine();

        Console.Write("Enter country name: ");
        country = Console.ReadLine();

        Console.Write("Enter population: ");
        population = int.Parse(Console.ReadLine());

        Console.Write("Enter phone code: ");
        phoneCode = Console.ReadLine();

        Console.WriteLine("Enter districts: ");
        districts = Console.ReadLine();
    }
    public void DisplayData()
    {
        Console.WriteLine($"\nCity: {name}");
        Console.WriteLine($"Country: {country}");
        Console.WriteLine($"Population: {population}");
        Console.WriteLine($"Phone code: {phoneCode}");
        Console.WriteLine($"Districts:  {districts}");
    }
    public string GetName() => name;
    public void SetName(string value) => name = value;
    public string GetCountry() => country;
    public void SetCountry(string value) => country = value;
    public int GetPopulation() => population;
    public void SetPopulation(int value) => population = value;
    public string GetPhoneCode() => phoneCode;
    public void SetPhoneCode(string value) => phoneCode = value;
    public void AddDistrict(string district) => districts = district;
}

internal class Employee
{
    private string fullName;
    private DateTime birthDate;
    private string phone;
    private string email;
    private string position;
    private string jobMusts;
    public void InputData()
    {
        Console.Write("Enter full name: ");
        fullName = Console.ReadLine();

        Console.Write("Enter birth date (yyyy-mm-dd): ");
        birthDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter phone number: ");
        phone = Console.ReadLine();

        Console.Write("Enter work email: ");
        email = Console.ReadLine();

        Console.Write("Enter position: ");
        position = Console.ReadLine();

        Console.Write("Enter job description: ");
        jobMusts = Console.ReadLine();
    }
    public void DisplayData()
    {
        Console.WriteLine($"\nFull Name: {fullName}");
        Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Job Description: {jobMusts}");
    }
    public string GetFullName() => fullName;
    public void SetFullName(string value) => fullName = value;
    public DateTime GetBirthDate() => birthDate;
    public void SetBirthDate(DateTime value) => birthDate = value;
    public string GetPhone() => phone;
    public void SetPhone(string value) => phone = value;
    public string GetEmail() => email;
    public void SetEmail(string value) => email = value;
    public string GetPosition() => position;
    public void SetPosition(string value) => position = value;
    public string GetJobDescription() => jobMusts;
    public void SetJobDescription(string value) => jobMusts = value;
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nTask 4:");
        City city = new City();
        city.InputData();
        city.DisplayData();

        Console.WriteLine("\nTask 5:");
        Employee employee = new Employee();
        employee.InputData();
        employee.DisplayData();
    }
}
