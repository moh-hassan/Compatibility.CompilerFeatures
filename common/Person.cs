using System;
using System.Diagnostics.CodeAnalysis;
namespace Compatibility.CompilerFeatures.Data;
public class Person
{
    //required feature in c# 11, provided in NET7
    public required int Id { get; set; }
    public string? Address { get; set; }
    public string? Name { get; init; }
    public Person()
    {
        Id = 5;
    }
}


public class Employee
{
    //required feature in c# 11, provided in NET7
    public required int Id { get; set; }

    [SetsRequiredMembers]
    public Employee()
    {
        Id = 3;
    }
    [SetsRequiredMembers]
    public Employee(int id)
    {
        Id = id;
    }
}
//record
public record Customer(string FirstName, string LastName);

//records with mutable properties and field:

public record Customer2
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
}

//record struct in c# 10
//Record structs can be mutable, both positional record structs and record structs with no positional parameters
public readonly record struct DailyTemperature(double HighTemp, double LowTemp);

public readonly record struct Point
{
    public double X { get; init; }
    public double Y { get; init; }
    public double Z { get; init; }
}

public record Person2(string FirstName, string LastName, string Id)
{
    internal string Id { get; init; } = Id;
}
public record Person3(string FirstName, string LastName)
{
    public string[]? PhoneNumbers { get; init; } 
}
