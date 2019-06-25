using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Non_Primitive_Types_Classes.UnitTests
{
    [TestClass]
    public class ClessesTests
    {
        [TestMethod]
        public void Person_IntroduceBy_ReturnNameOfThePerson()
        {
            var person = new Person();

            try
            {
                person.Introduce();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
