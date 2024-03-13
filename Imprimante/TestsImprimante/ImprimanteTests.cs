namespace ImprimanteTests
{
    [TestClass]
    public class ImprimanteTests
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            // Arrange
            var imprimante = new TestsImprimante.Imprimante();

            // Act
            string resultat = imprimante.HelloWorld();

            // Assert
            Assert.AreEqual("Hello, World!", resultat);
        }
        [TestMethod]
        public void TestPrixTotal()
        {
            // Arrange
            var imprimante = new TestsImprimante.Imprimante();

            // Act
            string resultat = imprimante.PrixTotal();

            // Assert
            Assert.AreEqual("Prix total : 0 EUR", resultat);
        }
    }
}
