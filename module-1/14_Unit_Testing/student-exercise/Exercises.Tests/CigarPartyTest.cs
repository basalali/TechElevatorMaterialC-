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
            
                bool result = cigarsP.HaveParty(46, false);
                Assert.AreEqual(true, result);

                result = cigarsP.HaveParty(700, true);
                Assert.AreEqual(true, result);

                result = cigarsP.HaveParty(10, true);
                Assert.AreEqual(false, result);

              



        }
    }
}
