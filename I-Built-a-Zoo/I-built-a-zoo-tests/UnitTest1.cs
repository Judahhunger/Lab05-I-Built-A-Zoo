using System;
using Xunit;
using I_Built_a_Zoo;
using I_Built_a_Zoo.classes;

namespace I_built_a_zoo_tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanMakeBatman()
        {
            TechBat batman = new TechBat("BATMAN");
            Assert.Equal("BATMAN", batman.Name);
        }


        [Fact]
        public void TestForTypeBat()
        {
            
            TechBat batman = new TechBat("BATMAN");
         
            Assert.True(batman is Bats);
        }

        [Fact]
        public void TestIFlyInterface()
        {
            TechBat batman = new TechBat("BATMAN");
            Assert.Equal("I go over Gothem to get to The bat cave", batman.FlyingTo("The bat cave"));
        }

        [Fact]
        public void TestSleepsForInWildBats()
        {
            TechBat batman = new TechBat("BATMAN");
            Assert.Equal(6, batman.SleepForHours);
        }

    }
}
