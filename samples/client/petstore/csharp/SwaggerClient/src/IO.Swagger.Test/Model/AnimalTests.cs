using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Animal
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AnimalTests
    {
        private Animal instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
			instance = new Animal(ClassName: "csharp test");
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Animal
        /// </summary>
        [Test]
        public void AnimalInstanceTest()
        {
			Assert.IsInstanceOfType(typeof(Animal), instance, "instance is a Animal");
        }

        /// <summary>
        /// Test deserialize a Dog from type Animal
        /// </summary>
        [Test]
        public void DogDeserializeFromAnimalTest()
        {
            // TODO uncomment below to test deserialize a Dog from type Animal
            //Assert.IsInstanceOf<Animal>(JsonConvert.DeserializeObject<Animal>(new Dog().ToJson()));
        }
        /// <summary>
        /// Test deserialize a Cat from type Animal
        /// </summary>
        [Test]
        public void CatDeserializeFromAnimalTest()
        {
            // TODO uncomment below to test deserialize a Cat from type Animal
            //Assert.IsInstanceOf<Animal>(JsonConvert.DeserializeObject<Animal>(new Cat().ToJson()));
        }

        /// <summary>
        /// Test the property 'ClassName'
        /// </summary>
        [Test]
        public void ClassNameTest()
        {
            // TODO: unit test for the property 'ClassName'
        }

    }

}
