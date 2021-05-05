using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest
{
    public class TestRectangle
    {
        [Test]
        public void TestArea([Range(0, 20)] int x, [Range(0, 20)] int y)
        {
            var temp = GeometricFigures.Rectangle.GetArea(x, y);
            Assert.IsTrue(x * y == temp, $"Мы ожидаем {x * y}, а пришло {temp}");
        }    
             //(1,4) (10,4) (11,4) (12,4) (13,4) (14,4) (15,4) (16,4) (17,1) (17,10) (17,11) (17,12) (17,13) (17,14) (17,15) (17,16)
            //(17,18) (17,19) (17,2) (17,20) (17,3) (17,4) (17,5) (17,6) (17,7) (17,8) (17,9) (18,4) (19,4) (2,4) (20,4) (3,4) (4,4) (5,4)
           //(6,4) (7,4) (8,4) (9,4)

        [Test]
        public void TestLength([Range(0, 20)] int x, [Range(0, 20)] int y)
        {
            var temp = GeometricFigures.Rectangle.GetLength(x, y);
            Assert.IsTrue((x + y) * 2 == temp, $"Мы ожидаем {(x + y) * 2}, а пришло {temp}");
        }
        //(0,2) (1,2) (10,2) (11,2) (12,2) (13,2) (14,2) (15,2) (16,2) (17,2) (18,2) (19,2) (2,2) (20,2) (3,2) (4,2) (5,0) (5,1) (5,10) (5,11)
       //(5,12) (5,13) (5,14) (5,15) (5,16) (5,17) (5,18) (5,19) (5,2) (5,20) (5,3) (5,4) (5,5) (5,6) (5,7) (5,8) (5,9) (6,2) (7,2) (8,2) (9,2)
    }
}