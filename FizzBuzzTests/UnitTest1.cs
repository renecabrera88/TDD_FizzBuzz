using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class Tests
    {
        //Equivalence Partitions and Bounderies
        //Test Case
        //Triangulation Green Bar Patter (Fake It, Fake It, Make It)
        
        [TestFixture]
        public class FizzBuzzerTests
        {
            [TestFixture]
            public class Go
            {
                [TestFixture]
                public class WhenNumberDivisibleBy3
                {
                    [TestCase(3)]
                    [TestCase(6)]
                    [TestCase(9)]
                    public void ShouldReturnFizz(int number)
                    {
                        //Arrange
                        var sut = new FizzBuzzer();
                        //Act
                        var actual = sut.Go(number);
                        //Assert
                        Assert.AreEqual("Fizz", actual);
                    }
                }

                [TestFixture]
                public class WhenNumberDivisibleBy5
                {
                    [TestCase(5)]
                    [TestCase(10)]
                    [TestCase(20)]
                    public void ShouldReturnBuzz(int number)
                    {
                        //Arrange
                        var sut = new FizzBuzzer();
                        //Act
                        var actual = sut.Go(number);
                        //Assert
                        Assert.AreEqual("Buzz", actual);
                    }
                }

                [TestFixture]
                public class WhenNumberDivisibleBy15
                {
                    [TestCase(15)]
                    [TestCase(30)]
                    [TestCase(75)]
                    public void ShouldReturnBuzz(int number)
                    {
                        //Arrange
                        var sut = new FizzBuzzer();
                        //Act
                        var actual = sut.Go(number);
                        //Assert
                        Assert.AreEqual("FizzBuzz", actual);
                    }
                }

                public class WhenNumberDivisibleByNothing
                {
                    [TestCase(1)]
                    [TestCase(2)]
                    [TestCase(4)]
                    public void ShouldReturnNumber(int number)
                    {
                        //Arrange
                        var sut = new FizzBuzzer();
                        //Act
                        var actual = sut.Go(number);
                        //Assert
                        Assert.AreEqual(number.ToString(), actual);
                    }
                }
            }
        }
    }
}