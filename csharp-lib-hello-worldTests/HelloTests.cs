// our tests
using System;

using csharp_lib_hello_world;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace csharp_lib_hello_world.Tests
{
    [TestClass()]
    public class HelloTests
    {
        // simple assert test
        [TestMethod()]
        public void SimpleAssertTest()
        {
            Assert.IsTrue(true);
        }

        // test default constructor
        [TestMethod()]
        public void PhraseDefaultConstructorTest()
        {
            // arrange
            string expected = "Hello, World!";
            string actual;
            Phrase hello = new Phrase();

            // act
            actual = hello.get();
            
            // assert
            Assert.AreEqual(actual, expected);
        }

        // test overloaded constructor
        [TestMethod()]
        public void PhraseOverloadedConstructorTest()
        {
            // arrange
            string expected = "Hello, James!";
            string actual;
            Phrase hello = new Phrase("Hello, James!");

            // act
            actual = hello.get();

            // assert
            Assert.AreEqual(actual, expected);
        }
    }
}