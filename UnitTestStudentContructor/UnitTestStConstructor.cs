using ClassRoom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestStudentContructor
{
    [TestClass]
    public class UnitTestStConstructor
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange.
            studerende student = new studerende("tricia",11, 31);

            //Act.
            string name = student.Navn;
            int month = student.F�dselsM�ned;
            int day = student.F�dselsDag;


            //Assert.
            Assert.AreEqual("tricia", name);
            Assert.AreEqual(11, month);
            Assert.AreEqual(31,day);


        }
    }
}
