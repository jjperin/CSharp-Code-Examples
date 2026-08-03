using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CSharp_Code_Examples;

namespace CSharpExamples.Tests
{
    public class MathsTests
    {

        //Hypotenuse
        [Fact]
        public void CalculateHypotenuseReturnsCorrectValue()
        {
            double result = Maths.CalculateHypotenuse(3, 4);
            Assert.Equal(5, result, 2);
        }

        //Circle
        [Fact]
        public void CalculateAreaReturnsCorrectArea()
        {
            double result = Maths.CalculateArea(4);
            Assert.Equal(50.27, result, precision: 2);
        }

        //Law of cosines
        [Fact]
        public void CalculateLawOfCosinesReturnsCorrectSide()
        {
            double result = Maths.CalculateLawOfCosines(2, 3, 20);
            Assert.Equal(1.31, result, precision: 2);
        }

        //Calculate discriminant
        [Fact]
        public void CalculateDiscrimantReturnsCorrectDiscriminant()
        {
            double result = Maths.CalculateDiscrimant(1, 3, -4);
            Assert.Equal(25, result, precision: 2);
        }

        [Fact]
        public void CalculateRoot_TwoRootsCase_ReturnsCorrectRoots()
        {
            double discriminant = Maths.CalculateDiscrimant(1, 3, -4);
            double[] roots = Maths.CalculateRoot(1, 3, discriminant);

            Assert.Equal(1, roots[0], precision: 2);
            Assert.Equal(-4, roots[1], precision: 2);
        }

        [Fact]
        public void CalculateDiscrimantNoRealRootsCase()
        {
            double result = Maths.CalculateDiscrimant(1, 1, 1);
            Assert.True(result < 0);
        }


    }
}
