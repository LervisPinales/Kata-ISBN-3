using Kata3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KataVol3
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Valid10()
        {
            Validatorisbn obj = new Validatorisbn();
            string isbn = "1566199093";

            bool result = obj.Valid10(isbn);

            Assert.IsTrue(result);

        }
        [Fact]
        public void unValid10()
        {
            Validatorisbn obj = new Validatorisbn();

            string isbn = "15024851";

            bool result = obj.Valid10(isbn);

            Assert.IsFalse(result);
        }
        [Fact]
        public void Valid13D()
        {
            Validatorisbn obj = new Validatorisbn();

            string isbn = "5147845147458";

            bool result = obj.Valid13(isbn);

            Assert.IsTrue(result);

        }

        [Fact]
        public void invalid13()
        {
            Validatorisbn obj = new Validatorisbn();

            string isbn = "5147845147458";

            bool result = obj.Valid13(isbn);

            Assert.IsFalse(result);
        }

    }
}