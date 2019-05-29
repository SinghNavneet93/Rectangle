using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program_Rect;
using NUnit.Framework;

namespace Program_Rect
{

    [TestFixture]
    class SENG8040_Assignment1_Test
    {
        [Test]
        public void GetLength_Input65_expectedLengthEquals65()
        {

            //Arrange
            int length = 65;
            int width = 45;

            int expectedLength = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actuallength = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedLength, actuallength);
        }

        [Test]
        public void SetLength_Input38_expectedLengthEquals38()
        {

            //Arrange
            int length = 38;
            int width = 19;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actuallength = testRectangle.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actuallength);
        }
        [Test]
        public void GetWidth_Input21_expectedWidthEequals21()
        {

            //Arrange
            int length = 29;
            int width = 21;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(width, actualResult);
        }
        [Test]
        public void SetWidth_Input38_expectedWidthEquals38()
        {

            //Arrange
            int length = 46;
            int width = 17;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualwidth = testRectangle.SetWidth(width);

            //Assert 
            Assert.AreEqual(expectedResult, actualwidth);
        }
        [Test]
        public void GetPerimeter_Input_Length10And_Width10_expectedPerimeterEquals40()
        {

            //Arrange
            int length = 10;
            int width = 10;

            int expectedResult = 2 * (length + width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input_Length9And_Width9_expectedAreaEquals81()
        {

            //Arrange
            int length = 9;
            int width = 9;

            int expectedResult = (length * width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
