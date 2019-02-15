using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;

namespace testerMethodenÅrstid
{
    [TestClass]
    public class UnitTestStuderende
    {
        [TestMethod]
        public void TestStuderendeÅrstid()
        {
            //Arrange
            studerende student = new studerende("test1", 12, 1);

            //Act
            string årstid = student.Årstid();

            //Assert

            Assert.AreEqual("Vinter", årstid);
        }
    }
}
