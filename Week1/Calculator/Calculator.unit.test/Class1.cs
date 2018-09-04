using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.unit.test
{
    [TestFixture]
    public class unittest
    {
        private Calculator uut_;
        [SetUp]
        public void Setup()
        {
            uut_ = new Calculator();
        }

        [Test]
        public void add_2plus2is4()
        {
            Assert.That(uut_.Add(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void add_minus5plus2()
        {
            Assert.That(uut_.Add(-5, 2), Is.EqualTo(-3));
        }

        [Test]
        public void sub_5and3is2()
        {
            Assert.That(uut_.Subtract(5, 3), Is.EqualTo(2));
        }

        [Test]
        public void sub_m5a3ism2()
        {
            Assert.That(uut_.Subtract(-5, 3), Is.EqualTo(-8));
        }

        [Test]
        public void pow_2over5er25()
        {
            Assert.That(uut_.Power(5, 2), Is.EqualTo(25));
        }

        [Test]
        public void mub_2t10i20()
        {
            Assert.That(uut_.Multiply(2, 10), Is.EqualTo(20));
        }

        [Test]
        public void Div_5divby10is0point5()
        {
            Assert.That(uut_.Divide(5, 10), Is.EqualTo(0.5));
        }

        [Test]
        public void Dividend0_AssertThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => uut_.Divide(0, 2));
        }
        [Test]
        public void Divisor0_AssertThrowException()
        {

            Assert.Throws<DivideByZeroException>(() => uut_.Divide(10, 0));
        }

    }
}
