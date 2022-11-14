namespace Compatibility.CompilerFeatures.Demo;
public class Person
{
    //required feature in c# 11, provided in NET7
    public required int Id { get; set; }
    public required string Name { get; init; } //init-only feature in c# 9
}

public readonly record struct DailyTemperature(double HighTemp, double LowTemp);
public readonly record struct DailyTemperature2(double HighTemp, double LowTemp)
{
    public double Mean => (HighTemp + LowTemp) / 2.0;
}

public record Department
{

}