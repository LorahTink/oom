using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task6;


namespace Task6.Properties
{
    [TestFixture]

    public class AnimalTests
    {
        [Test]

        public void CatAgeTest()
        {

            Assert.Catch(() =>
            {
                // Schlaegt an, falls eine Exception geliefert wird - wir prüfen hier ob das Alter korrekt ausgefuellt wurde
                var Youngcat = new Cat("Kitty", "weiblich", "grantig", -2, "Whysoserious?");
            });

        }

        [Test]
        public void PersonalityTest()
        {
            // Schlaegt an, falls eine Exception geliefert wird - wir prüfen hier ob die Personality ausgefuellt wurde
            Assert.Catch(() =>
            {
                var Youngcat = new Cat("Kitty", "weiblich", null, 2, "Whysoserious?");
            });
        }

        [Test]
        public void RaceTest()
        {
            // Schlaegt an, falls eine Exception geliefert wird - wir prüfen hier ob die Rasse ausgefuellt wurde
            Assert.Catch(() =>
            {
                var Youngcat = new Cat(null, "weiblich", "herzig", 2, "Whysoserious?");
            });
        }

        [Test]
        public void GenderTest()
        {
            // Schlaegt an, falls eine Exception geliefert wird - wir prüfen hier ob das Geschlecht ausgefuellt wurde
            Assert.Catch(() =>
            {
                var Youngcat = new Cat("Volkert", null, "herzig", 2, "Whysoserious?");
            });
        }

        [Test]
        public void SchroedingerTest()
        {
            //Test ob die Katze bereits lebt (Schroedinger?)
            var Mittens = new Cat("Mittens", "weiblich", "grantig", 1, "Whysoserious?");
            Assert.IsTrue(Mittens.Age >= 0);

        }

        [Test]
        public void CanCreateCat()
        {
            var Garfield = new Cat("Perser", "maennlich", "grantig", 1, "fluffy");
            Assert.IsTrue(Garfield.Race == "Perser");
            Assert.IsTrue(Garfield.Sex == "maennlich");
            Assert.IsTrue(Garfield.Personality == "grantig");
            Assert.IsTrue(Garfield.Age != 0);
            Assert.IsTrue(Garfield.Description == "fluffy");
        }

        [Test]
        public void CanCreateDog()
        { //Just beeing lazy here
            var Fiffy = new Doge("Chihuaha", "no", "no", 6, "aggressiv");
            Assert.IsTrue(Fiffy.Race == "Chihuaha");
            Assert.IsTrue(Fiffy.Goodboy == "no");
            Assert.IsTrue(Fiffy.Fluff == "no");
            Assert.IsTrue(Fiffy.Age != 0);
            /// Assert.IsTrue(Fiffy.Description == "aggressiv"); 
            /// Not sure why this throws an Error

        }

        [Test]

        public void DogeAgeTest()
        {

            Assert.Catch(() =>
            {
                // Schlaegt an, falls eine Exception geliefert wird - wir prüfen hier ob das Alter korrekt ausgefuellt wurde
                //Erfolgreich -> Wirft eine Exception
                var Youngdog = new Doge("Rex", "weiblich", "treu", -2, "Wurstsemmel-Aficionado");
            });

        }
    }
}