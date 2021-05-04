using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest
{
    class TestSquare
    {
        [Test]
        public void TestArea([Range(0, 20)] int x)
        {
            var temp = GeometricFigures.Square.GetArea(x);
            Assert.IsTrue(x * x == temp, $"Мы ожидаем {x * x}, а пришло {temp}");  
        }

        //18, 7

        [Test]
        public void TestLength([Range(0, 20)] int x)
        {
            var temp = GeometricFigures.Square.GetLength(x);
            Assert.IsTrue(x * 4 == temp, $"Мы ожидаем {x * 4}, а пришло {temp}");  
        }

        //6, 9
    }
}
