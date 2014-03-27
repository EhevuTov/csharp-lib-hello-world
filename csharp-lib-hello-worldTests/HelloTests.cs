using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_lib_hello_world;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace csharp_lib_hello_world.Tests
{
    [TestClass()]
    public class HelloTests
    {
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
    }
}