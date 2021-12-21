using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegestartionRegex;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();
        RegestrationRegexPattern registrationPattern = new RegestrationRegexPattern();
        [TestMethod]
        public void TestFirstName()
        {
            var result = registrationPattern.ValidateFirstName("Arati");
            Assert.AreEqual("validation successfull", result);
        }
        [TestMethod]
        public void TestFirstNameException()
        {
            try
            {
                var result = registrationPattern.ValidateFirstName("");
            }
            catch (RegistrationCustomExceptions ex)
            {
                Assert.AreEqual("FirstName Should not be null", ex.Message);
            }
        }
        [TestMethod]
        public void TestLastName()
        {
            var result = registrationPattern.ValidateLastName("Naik");
            Assert.AreEqual("validation successfull", result);
        }

    }
}