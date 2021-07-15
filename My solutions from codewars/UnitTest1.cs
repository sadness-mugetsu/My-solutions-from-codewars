using NUnit.Framework;
using System;

namespace My_solutions_from_codewars
{
    public static class Kata
    {
        public static string Greet(string name)
        {
            throw new NotImplementedException("Greet is not implemented.");
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
        }
    }
}