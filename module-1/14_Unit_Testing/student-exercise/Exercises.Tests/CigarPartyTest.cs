using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void HaveParty()
        {

            //   haveParty(30, false) → false
            //haveParty(50, false) → true
            //haveParty(70, true) → true


                CigarParty cigarsP = new CigarParty();
            
                bool result = cigarsP.HaveParty(30, false);
                Assert.AreEqual(false, result);

                result = cigarsP.HaveParty(50, false);
                Assert.AreEqual(true, result);

                result = cigarsP.HaveParty(70, true);
                Assert.AreEqual(true, result);

              



        }
    }
}
