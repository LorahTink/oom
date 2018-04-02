using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task4.Properties
{
    [TestFixture]

    public class AnimalTests
    {
        [Test]

        public void AgeTest()
        {
          
            Assert.Catch(() =>
                {
                    var Youngcat = new Cat("Kitty", "weiblich" , "grantig", -1, "Whysoserious?");
                });
            
        }

        [Test]
        public void GenderTest()
        {
           var Mittens = new Cat("Mittens", "weiblich", "grantig", 1, "Whysoserious?");
            Assert.IsTrue(Mittens.Sex == "männlich");

        }
    }
}
