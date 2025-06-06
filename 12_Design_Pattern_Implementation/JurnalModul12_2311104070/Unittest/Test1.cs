using Microsoft.VisualStudio.TestTools.UnitTesting;
using JurnalModul12_2311104070;
using PangkatIterasi;

namespace PangkatIterasiTests
{
    [TestClass]
    public class PangkatCalculatorTests
    {
        [TestMethod]
        public void HitungPangkat_PositiveBasePositivePower_ReturnsCorrectResult()
        {
            // Arrange
            double angka = 2;
            int pangkat = 3;
            double expected = 8;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void HitungPangkat_PositiveBaseNegativePower_ReturnsCorrectResult()
        {
            // Arrange
            double angka = 2;
            int pangkat = -2;
            double expected = 0.25;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void HitungPangkat_NegativeBaseEvenPower_ReturnsPositiveResult()
        {
            // Arrange
            double angka = -2;
            int pangkat = 2;
            double expected = 4;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void HitungPangkat_NegativeBaseOddPower_ReturnsNegativeResult()
        {
            // Arrange
            double angka = -2;
            int pangkat = 3;
            double expected = -8;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void HitungPangkat_ZeroPower_ReturnsOne()
        {
            // Arrange
            double angka = 5;
            int pangkat = 0;
            double expected = 1;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void HitungPangkat_ZeroBasePositivePower_ReturnsZero()
        {
            // Arrange
            double angka = 0;
            int pangkat = 5;
            double expected = 0;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void HitungPangkat_OneBaseAnyPower_ReturnsOne()
        {
            // Arrange
            double angka = 1;
            int pangkat = 100;
            double expected = 1;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void HitungPangkat_DecimalBasePositivePower_ReturnsCorrectResult()
        {
            // Arrange
            double angka = 2.5;
            int pangkat = 2;
            double expected = 6.25;

            // Act
            double actual = PangkatCalculator.HitungPangkat(angka, pangkat);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}