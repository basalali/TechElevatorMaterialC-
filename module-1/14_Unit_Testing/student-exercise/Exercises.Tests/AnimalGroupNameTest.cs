using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNamTest
    {
    
        [TestMethod]
        public void GetHerdTest()
        {
            //Arrange
            AnimalGroupName testClass = new AnimalGroupName();


            //ACT
            string result = testClass.GetHerd("giraffe");

            //Assert

            Assert.AreEqual("Tower", result);

            result = testClass.GetHerd("");
            Assert.AreEqual("unknown", result);

            result = testClass.GetHerd("rhino");
            Assert.AreEqual("Crash", result);

            result = testClass.GetHerd("elephant");
            Assert.AreEqual("Herd", result);

            result = testClass.GetHerd("lion");
            Assert.AreEqual("Pride", result);

            result = testClass.GetHerd("crow");
            Assert.AreEqual("Murder", result);

            result = testClass.GetHerd("flamingo");
            Assert.AreEqual("Pat", result);

            result = testClass.GetHerd("pigeon");
            Assert.AreEqual("Kit", result);

            result = testClass.GetHerd("deer");
            Assert.AreEqual("Herd", result);

            result = testClass.GetHerd("dog");
            Assert.AreEqual("Pack", result);

            result = testClass.GetHerd("crocodile");
            Assert.AreEqual("Float", result);

            result = testClass.GetHerd("BROOOO!! THIS IS INSANE!!!");
            Assert.AreEqual("unknown", result);

            result = testClass.GetHerd("");
            Assert.AreEqual("unknown", result);

        }
    }
}
