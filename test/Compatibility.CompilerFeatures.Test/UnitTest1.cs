using Compatibility.CompilerFeatures.Data;
using NUnit.Framework;

namespace Compatibility.CompilerFeatures.Test;
public class Tests
{
    [Test]
    public void Require_feature_should_be_compiled_in_old_frameworks()
    {
        //Arrange
        //Next commented line raise Error CS9035  Required member 'Person.Id' must be set in the object initializer or attribute constructor.
        //var person = new Person {Name = "jack" };

        //Act
        //ok 
        var person = new Person { Id = 1, Name = "jack" };

        //Assert
        Assert.Pass();
    }

    [Test]
    public void Require_feature_with_SetsRequiredMembersAttribute_should_be_compiled_in_old_frameworks()
    {
        //Arrange
        //Act
        //ok, no CS9035  Required member error
        var emp = new Employee();
             
        //ok, no CS9035  Required member error
        var emp2 = new Employee(1);
        //Assert
        Assert.Pass();
    }

    [Test]
    public void Record_in_c9_should_be_compiled()
    {
        var customer = new Customer ("jack", "Mido" );
        var customer2 = new Customer2 {FirstName = "jack",LastName = "Mido"};
        Assert.Pass();
    }

    [Test]
    public void record_using_with()
    {
        Person3 personA = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
        var personB = personA with { };
        Assert.That(personA == personB); 

    }
}
