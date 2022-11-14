using Compatibility.CompilerFeatures.Demo;
using NUnit.Framework;
using System;

namespace Compatibility.CompilerFeatures.Test
{
    public class Tests
    {
        private DailyTemperature[] data = new DailyTemperature[]
        {
            new DailyTemperature(HighTemp: 57, LowTemp: 30),
            new DailyTemperature(60, 35),
            new DailyTemperature(63, 33),
            new DailyTemperature(68, 29),
        };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Require_and_record_init_test()
        {
            Console.WriteLine("--------------required feature of c# 11 in net4x-------");
            var person = new Person { Id = 1, Name = "jack" };
            Console.WriteLine($"id= {person.Id}, Name={person.Name}");
            Console.WriteLine("--------------record feature of c# 9  in net4x-------");
            foreach (var item in data)
                Console.WriteLine(item);
        }
    }
}
