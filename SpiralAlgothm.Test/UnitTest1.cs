using NUnit.Framework;
using SpiralAlgoth;
using System;
using System.IO;

namespace SpiralAlgothm.Test
{
    public class Tests
    {
       
    

        [Test]
        public void SpiralPrint_ShouldPrintElementsInSpiralOrder()
        {
            // Arrange
            int[,] dizi = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            string expectedOutput = "1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10 ";

            Matrix matrix = new Matrix(dizi);

            // Redirect console output
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            matrix.SpiralPrint();
            string actualOutput = stringWriter.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}