using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest
{
    class TestTriangle
    {
        [Test]
        public void TestArea([Range(0, 20)] double x, [Range(0, 20)] double y, [Range(0, 20)] double z)
        {
            var temp = GeometricFigures.Triangle.GetArea(x, y, z);
            double p = (x + y + z) / 2;
            var temp2 = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            Assert.IsTrue(temp2 == temp, $"Мы ожидаем {temp2}, а пришло {temp}");
        }

        [Test]
        public void TestLength([Range(0, 20)] double x, [Range(0, 20)] double y, [Range(0, 20)] double z)
        {
            var temp = GeometricFigures.Triangle.GetLength(x, y, z);
            Assert.IsTrue((x + y + z) == temp, $"Мы ожидаем {(x + y + z)}, а пришло {temp}");
        }

        // здесь очень много не выполненных тестов

    }
}