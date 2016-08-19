using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Randall
{
    [TestFixture]
    public class StringCalcTest
    {
        [TestCase("", 0)]
        public void ShouldReturnZeroWHenInputIsEmpty(string input, int expected)
        {
            StringCalc target = new StringCalc();
            int actual = target.Add(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("10,10,5", 25)]
        [TestCase("10,10,10,5", 35)]
        [TestCase("10,50,10,5", 75)]
        public void ShouldReturnSumWhenINputIsDelimitedByComma(string input, int expected)
        {
            StringCalc target = new StringCalc();
            int actual = target.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("10,10\n5", 25)]
        [TestCase("10,10\n10,5", 35)]
        [TestCase("10\n50,10,5", 75)]
        public void ShouldReturnSumAllowReturnCharacter(string input, int expected)
        {
            StringCalc target = new StringCalc();
            int actual = target.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("//;\n10;10\n5", 25)]
        [TestCase("//@\n10@10\n10@5", 35)]
        [TestCase("//|\n10\n50|10|5", 75)]
        public void ShouldReturnSumAllowChangedDelim(string input, int expected)
        {
            StringCalc target = new StringCalc();
            int actual = target.Add(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
